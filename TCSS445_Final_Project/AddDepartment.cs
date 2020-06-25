using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCSS445_Final_Project
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
            // Populate Locations dropdown
            DataTable dt = SqlManager.query("SELECT LocationName FROM Locations");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                location.Items.Add(dt.Rows[i][0]);
            }
        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate Departments dropdown
            department.Items.Clear();
            DataTable dt = SqlManager.query("SELECT DepartmentName FROM Departments WHERE LocationID =" +
                "(SELECT LocationID FROM Locations WHERE LocationName = '" + location.Text + "')");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                department.Items.Add(dt.Rows[i][0]);
            }
            department.Enabled = true;
            setButtonVisibility();
        }

        private void department_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void setButtonVisibility()
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(department.Text) &&
                !department.Items.Contains(department.Text);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Check if location department combo already exists
            var sql = "SELECT 1 FROM Departments WHERE DepartmentName = '" + department.Text + "' " +
                "AND LocationID = (SELECT LocationID FROM Locations WHERE LocationName = '" + location.Text + "')";
            if (SqlManager.query(sql).Rows.Count == 0)
            {
                sql = "INSERT INTO Departments (LocationID, DepartmentName) " +
                    "SELECT LocationID, '" + department.Text + "' FROM Locations WHERE LocationName = '" + location.Text + "'";
                if (SqlManager.insert(sql))
                {
                    department.Items.Add(department.Text);
                    submit.Enabled = false;
                    MessageBox.Show("Department " + department.Text + " added to database.", "Department Added");
                }
                else
                {
                    MessageBox.Show("Department not added, contact database admin.", "Department Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Department already exists, database not updated.", "Department Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

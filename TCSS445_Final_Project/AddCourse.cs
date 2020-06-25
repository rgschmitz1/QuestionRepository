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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
            // Populate Locations dropdown
            DataTable dt = SqlManager.query("SELECT LocationName FROM Locations");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                location.Items.Add(dt.Rows[i][0]);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Check if course, location, department combo already exists
            var sql = "SELECT 1 FROM Courses WHERE CourseName = '" + course.Text + "' " +
                "AND DepartmentID = (SELECT DepartmentID FROM Departments WHERE DepartmentName = '" + department.Text + "' " +
                "AND LocationID = (SELECT LocationID FROM Locations WHERE LocationName = '" + location.Text + "'))";
            if (SqlManager.query(sql).Rows.Count == 0)
            {
                sql = "INSERT INTO Courses (LocationID, DepartmentID, CourseName) " +
                    "SELECT LocationID, DepartmentID, '" + course.Text + "' FROM Departments WHERE DepartmentName = '" + department.Text + "' " +
                    "AND LocationID = (SELECT LocationID FROM Locations WHERE LocationName = '" + location.Text + "')";
                if (SqlManager.insert(sql))
                {
                    course.Items.Add(course.Text);
                    submit.Enabled = false;
                    MessageBox.Show("Course " + course.Text + " added to database.", "Course Added");
                }
                else
                {
                    MessageBox.Show("Course not added, contact database admin.", "Course Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Course already exists, database not updated.", "Course Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate Courses dropdown
            course.Items.Clear();
            DataTable dt = SqlManager.query("Select CourseName FROM Courses WHERE DepartmentID =" +
                "(SELECT DepartmentID FROM Departments WHERE DepartmentName = '" + department.Text + "' " +
                "AND LocationID = (SELECT LocationID FROM Locations WHERE LocationName = '" + location.Text + "'))");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                course.Items.Add(dt.Rows[i][0]);
            }
            course.Enabled = true;
            setButtonVisibility();
        }

        private void setButtonVisibility()
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(course.Text) &&
                !course.Items.Contains(course.Text);
        }

        private void course_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }
    }
}

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
    public partial class AddLocation : Form
    {
        public AddLocation()
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
            var sql = "SELECT 1 FROM Locations WHERE LocationName = '" + location.Text + "'";
            if (SqlManager.query(sql).Rows.Count == 0)
            {
                sql = "INSERT INTO Locations (LocationName) VALUES ('" + location.Text + "')";
                if (SqlManager.insert(sql))
                {
                    location.Items.Add(location.Text);
                    submit.Enabled = false;
                    MessageBox.Show("Location " + location.Text + " added to database.", "Location Added");
                }
                else
                {
                    MessageBox.Show("Location not added, contact database admin.", "Location Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Location already exists, database not updated.", "Location Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void location_TextChanged(object sender, EventArgs e)
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(location.Text) && !location.Items.Contains(location.Text);
        }
    }
}

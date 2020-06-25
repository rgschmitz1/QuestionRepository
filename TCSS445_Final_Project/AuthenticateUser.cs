using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCSS445_Final_Project
{
    public partial class AuthenticateUser : Form
    {
        public AuthenticateUser() => InitializeComponent();

        private void login_Click(object sender, EventArgs e)
        {
            var Username = username.Text;
            // Password should be hashed, I don't have time to work on this.
            var Password = password.Text;
          
            var sql = "SELECT UserID FROM Users " +
                "WHERE UserName='" + Username + "' AND UserPassword='" + Password + "' " +
                "AND NOT EXISTS (SELECT NonActiveID FROM NonActive WHERE UserID = NonActiveID)";
            DataTable datatable = SqlManager.query(sql);
            // Test SQL query
            if (datatable.Rows.Count == 0)
            {
                MessageBox.Show("User could not be authenticated.", "User Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var UserID = Convert.ToInt32(datatable.Rows[0][0]);
                // Check if user is admin, if so redirect to admin form, otherwise redirect to user form
                sql = "Select * FROM Admins WHERE AdminID=" + UserID;
                datatable = SqlManager.query(sql);
                this.Hide();
                if (datatable.Rows.Count == 0)
                {
                    // Open user controls
                    new UserForm(UserID).ShowDialog();
                }
                else
                {
                    // Open admin controls
                    new AdminForm().ShowDialog();
                }
                this.Close();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }
        private void setButtonVisibility()
        {
            login.Enabled = (!string.IsNullOrWhiteSpace(username.Text) &&
                !string.IsNullOrWhiteSpace(password.Text));
        }

        private void databaseConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ConfigManagerSetup().ShowDialog();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}

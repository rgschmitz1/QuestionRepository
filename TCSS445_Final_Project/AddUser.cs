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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var Username = username.Text;
            // Password should be hashed, I don't have time to work on this.
            var Password = password.Text;

            var sql = "SELECT UserID FROM Users WHERE UserName='" + Username + "'";
            DataTable datatable = SqlManager.query(sql);
            // Test SQL query
            if (datatable.Rows.Count == 1)
            {
                userExists();
            }
            else
            {
                sql = "INSERT INTO Users " +
                    "(UserName, UserPassword) VALUES " +
                    "('" + Username + "', '" + Password + "')";
                if (SqlManager.insert(sql))
                {
                    if (admin.Checked)
                    {
                        sql = "INSERT INTO Admins SELECT UserID FROM Users WHERE UserName = '" + Username + "'";
                        if (SqlManager.insert(sql))
                        {
                            userAdded(Username);
                        }
                        else
                        {
                            databaseError();
                        }
                    }
                    else
                    {
                        userAdded(Username);
                    }
                }
                else
                {
                    databaseError();
                }
            }
        }

        private void userAdded(string username)
        {
            MessageBox.Show("User " + username + " added to database.", "User Added",
                MessageBoxButtons.OK);
        }

        private void userExists()
        {
            MessageBox.Show("User already exists in database, try a different username.", "User Already Exists",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void databaseError()
        {
            MessageBox.Show("User not created, contact database admin.", "User Creation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

            setButtonVisibility();
        }

        private void confirm_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private bool passwordMatch()
        {
            if (!string.IsNullOrWhiteSpace(password.Text) &&
                !string.IsNullOrWhiteSpace(confirm.Text))
                
            {
                if (password.Text.Equals(confirm.Text))
                {
                    mismatch.Visible = false;
                    return true;
                }
                mismatch.Visible = true;
            }
            else
            {
                mismatch.Visible = false;
            }
            return false;
        }

        private void setButtonVisibility()
        {
            submit.Enabled = (passwordMatch() && !string.IsNullOrWhiteSpace(username.Text));
        }
    }
}

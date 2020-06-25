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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
            // Populate Users dropdown
            DataTable dt = SqlManager.query("SELECT Username FROM Users");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                users.Items.Add(dt.Rows[i][0]);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String sql;
            // Update password
            if (!string.IsNullOrWhiteSpace(password.Text) &&
                !string.IsNullOrWhiteSpace(confirm.Text))
            {
                sql = "UPDATE Users SET UserPassword = '" + password.Text + "' WHERE UserName = '" + users.Text + "'";
                if (!SqlManager.update(sql))
                {
                    MessageBox.Show("User password not updated, contact database admin.", "User Update Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Update NonActive status
            if (deactivate.Checked != userActive())
            {
                if (!userActive())
                {
                    sql = "INSERT INTO NonActive SELECT UserID FROM Users WHERE UserName = '" + users.Text + "'";
                }
                else
                {
                    sql = "DELETE FROM NonActive WHERE NonActiveID = (SELECT UserID FROM Users WHERE UserName = '" + users.Text + "')";
                }
                if (!SqlManager.update(sql))
                {
                    MessageBox.Show("NonActive database not updated, contact database admin.", "User Update Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Update Admin status
            if (admin.Checked != userAdmin())
            {
                if (userAdmin())
                {
                    sql = "DELETE FROM Admins WHERE AdminID = (SELECT UserID FROM Users WHERE UserName = '" + users.Text + "')";
                }
                else
                {
                    sql = "INSERT INTO Admins SELECT UserID FROM Users WHERE UserName = '" + users.Text + "'";
                }
                if (!SqlManager.update(sql))
                {
                    MessageBox.Show("Admin database not updated, contact database admin.", "User Update Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("User " + users.Text + " successfully updated.", "User Updated");
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void confirm_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if user is deactivated
            deactivate.Checked = userActive();
            // Check if user is admin
            admin.Checked = userAdmin();

            setButtonVisibility();
        }

        private bool userActive()
        {
            DataTable dt = SqlManager.query("SELECT * FROM NonActive WHERE NonActiveID = (SELECT UserID FROM Users WHERE Username = '" + users.Text + "')");
            return dt.Rows.Count != 0;
        }

        private bool userAdmin()
        {
            DataTable dt = SqlManager.query("SELECT * FROM Admins WHERE AdminID = (SELECT UserID FROM Users WHERE Username = '" + users.Text + "')");
            return dt.Rows.Count != 0;
        }

        private bool passwordMatch()
        {
            var ret = false;
            if (!string.IsNullOrWhiteSpace(password.Text) &&
                !string.IsNullOrWhiteSpace(confirm.Text))
            {
                if (password.Text.Equals(confirm.Text))
                {
                    mismatch.Visible = false;
                    ret = true;
                }
                else
                {
                    mismatch.Visible = true;
                }
            }
            else if (string.IsNullOrWhiteSpace(password.Text) &&
                string.IsNullOrWhiteSpace(confirm.Text))
            {
                mismatch.Visible = false;
                ret = true;
            }
            return ret;
        }

        private void setButtonVisibility()
        {
            submit.Enabled = passwordMatch() && users.SelectedIndex != -1;
        }
    }
}
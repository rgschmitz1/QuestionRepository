using System;
using System.Configuration;
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
    public partial class ConfigManagerSetup : Form
    {
        public ConfigManagerSetup()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["TCSS445_Final_Project.Properties.Settings.Schmitz_Bob_dbConnectionString"].ConnectionString =
                "Data Source=" + server.Text + ";Initial Catalog=" + database.Text + ";Integrated Security=True";
            Console.WriteLine(connectionStringsSection.ConnectionStrings["TCSS445_Final_Project.Properties.Settings.Schmitz_Bob_dbConnectionString"].ConnectionString);
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            MessageBox.Show("SQL Server settings are updated as follows\n\n" +
                connectionStringsSection.ConnectionStrings["TCSS445_Final_Project.Properties.Settings.Schmitz_Bob_dbConnectionString"].ConnectionString,
                "SQL Server ConnectionString",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void server_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void database_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void setButtonVisibility()
        {
            submit.Enabled = (!string.IsNullOrWhiteSpace(server.Text) &&
                !string.IsNullOrWhiteSpace(database.Text));
        }

        private void defaults_Click(object sender, EventArgs e)
        {
            server.Text = "localhost\\TCSS445";
            database.Text = "Schmitz_Bob_db";
        }
    }
}

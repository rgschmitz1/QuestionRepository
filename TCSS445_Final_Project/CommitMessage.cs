using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCSS445_Final_Project
{
    public partial class CommitMessage : Form
    {
        public string msg { set; get; }

        public CommitMessage()
        {
            InitializeComponent();
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(message.Text);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            msg = message.Text;
            this.Close();
        }
    }
}

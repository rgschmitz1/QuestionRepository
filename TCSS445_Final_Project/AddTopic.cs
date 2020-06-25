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
    public partial class AddTopic : Form
    {
        public AddTopic()
        {
            InitializeComponent();
            // Populate Topics dropdown
            DataTable dt = SqlManager.query("SELECT TopicDescription FROM Topics");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                topic.Items.Add(dt.Rows[i][0]);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var sql = "SELECT 1 FROM Topics WHERE TopicDescription = '" + topic.Text + "'";
            if (SqlManager.query(sql).Rows.Count == 0)
            {
                sql = "INSERT INTO Topics (TopicDescription) VALUES ('" + topic.Text + "')";
                if (SqlManager.insert(sql))
                {
                    topic.Items.Add(topic.Text);
                    submit.Enabled = false;
                    MessageBox.Show("Topic " + topic.Text + " added to database.", "Topic Added");
                }
                else
                {
                    MessageBox.Show("Topic not added, contact database admin.", "Topic Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Topic already exists, database not updated.", "Topic Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void topic_TextChanged(object sender, EventArgs e)
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(topic.Text) && !topic.Items.Contains(topic.Text);
        }
    }
}

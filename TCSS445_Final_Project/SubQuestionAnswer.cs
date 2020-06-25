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
    public partial class SubQuestionAnswer : Form
    {
        // Provide external reference for
        ComboBox combobox;
        // Create a datatable to store details
        DataTable dt;
        // index of item
        int index;
        // Check if 
        bool isAnswer;

        public SubQuestionAnswer(ComboBox theCombobox, DataTable theDt, int theIndex, bool answer)
        {
            combobox = theCombobox;
            dt = theDt;
            index = theIndex;
            isAnswer = answer;

            InitializeComponent();

            if (index != -1 && !isAnswer)
            {
                body.Text = dt.Rows[index]["SubQuestionText"].ToString();
                image.Text = dt.Rows[index]["SubQuestionImage"].ToString();
                submit.Enabled = false;
            }
            else if (index != -1 && isAnswer)
            {
                body.Text = dt.Rows[index]["AnswerText"].ToString();
                image.Text = dt.Rows[index]["AnswerImage"].ToString();
                submit.Enabled = false;
            }
        }

        private void body_TextChanged(object sender, EventArgs e)
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(body.Text);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            // Check if user would like to discard
            if (submit.Enabled)
            {
                var result = MessageBox.Show("Would you like to discard your changes?",
                    "Discard?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Check if user would like to submit
            var result = MessageBox.Show("Would you like to submit your changes?",
                "Commit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (index == -1 && !isAnswer)
                {
                    combobox.Items.Add("SubQuestion " + dt.Rows.Count);
                    var row = dt.NewRow();
                    row["SubQuestionText"] = body.Text;
                    row["SubQuestionImage"] = image.Text;
                    dt.Rows.Add(row);
                }
                else if (!isAnswer)
                {
                    dt.Rows[index]["SubQuestionText"] = body.Text;
                    dt.Rows[index]["SubQuestionImage"] = image.Text;
                }
                else if (index == -1 && isAnswer)
                {
                    combobox.Items.Add("Answer " + dt.Rows.Count);
                    var row = dt.NewRow();
                    row["AnswerText"] = body.Text;
                    row["AnswerImage"] = image.Text;
                    dt.Rows.Add(row);
                }
                else if (isAnswer)
                {
                    dt.Rows[index]["AnswerText"] = body.Text;
                    dt.Rows[index]["AnswerImage"] = image.Text;
                }
                this.Close();
            }
        }

        private void image_TextChanged(object sender, EventArgs e)
        {
            submit.Enabled = !string.IsNullOrWhiteSpace(body.Text);
        }
    }
}

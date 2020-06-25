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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog();
        }

        private void updateuser_Click(object sender, EventArgs e)
        {
            new UpdateUser().ShowDialog();
        }

        private void location_Click(object sender, EventArgs e)
        {
            new AddLocation().ShowDialog();
        }

        private void department_Click(object sender, EventArgs e)
        {
            new AddDepartment().ShowDialog();
        }

        private void course_Click(object sender, EventArgs e)
        {
            new AddCourse().ShowDialog();
        }

        private void topic_Click(object sender, EventArgs e)
        {
            new AddTopic().ShowDialog();
        }
    }
}

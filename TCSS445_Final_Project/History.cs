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
    public partial class History : Form
    {
        public History(DataTable dt)
        {
            InitializeComponent();
            dataGridHistory.DataSource = dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

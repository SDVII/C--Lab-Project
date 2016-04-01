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
        private int teachID;
        private Teacher_Portal teacher_Portal;

        public Schedule(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacher_Portal.Enabled = true;
        }

        private void btnAccSchd_Click(object sender, EventArgs e)
        {
            this.Close();
            teacher_Portal.Enabled = true;
        }
    }
}

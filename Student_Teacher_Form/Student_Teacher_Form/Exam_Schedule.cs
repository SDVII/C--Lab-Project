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
    public partial class Exam_Schedule : Form
    {
        private int stuID;
        private Student_Portal student_Portal;

        public Exam_Schedule(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
        }

        private void btnAccExSchd_Click(object sender, EventArgs e)
        {
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Exam_Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

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
    public partial class About : Form
    {
        private bool check;
        private Student_Portal student_Portal;
        private Teacher_Portal teacher_Portal;

        public About(bool check, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.check = check;
            this.teacher_Portal = teacher_Portal;
        }

        public About(bool check, Student_Portal student_Portal) 
        {
            InitializeComponent();
            this.check = check;
            this.student_Portal = student_Portal;
        }

        private void pbGitB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Hephaa");
        }

        private void pbGitHa_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hanikeddah");
        }

        private void pbGitBHo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SDVII");
        }

        private void About_Click(object sender, EventArgs e)
        {
            if (check == true)
                student_Portal.Enabled = true;
            else
                teacher_Portal.Enabled = true;
            this.Close();
        }
    }
}

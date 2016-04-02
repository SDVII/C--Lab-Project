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
    public partial class Settings : Form
    {
        private Student_Portal student_Portal;
        private int stuID = 0;
        private Teacher_Portal teacher_Portal;
        private int teachID = 0;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
        }

        public Settings(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";
        }

        private void btnAccS_Click(object sender, EventArgs e)
        {
            if(teachID!=0)
            {
                this.Close();
                teacher_Portal.Enabled = true;
            }
            else
            {
                this.Close();
                student_Portal.Enabled = true;
            }
            
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (teachID != 0)
                teacher_Portal.Enabled = true;
            else
                student_Portal.Enabled = true;
        }
    }
}

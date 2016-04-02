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
        private Teacher teacher = null;
        private Teacher_Portal teacher_Portal;
        private Student student = null;
        private Student_Portal student_Portal;

        public Schedule(Teacher teacher, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.teacher_Portal = teacher_Portal;
            this.Text = teacher.Id + "";
        }

        public Schedule(Student student, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.student = student;
            this.student_Portal = student_Portal;
            this.Text = student.Id + "";
        }

        public void fillSchedule()
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(teacher != null)
                teacher_Portal.Enabled = true;
            else
                student_Portal.Enabled = true;
        }

        private void btnAccSchd_Click(object sender, EventArgs e)
        {
            if (teacher != null)
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
    }
}

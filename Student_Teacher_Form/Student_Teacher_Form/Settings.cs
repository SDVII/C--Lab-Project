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
        private Student student = null;
        private Teacher_Portal teacher_Portal;
        private Teacher teacher = null;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Student student, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.student = student;
            this.student_Portal = student_Portal;
            this.Text = student.Id + "";
            fillData();
        }

        public Settings(Teacher teacher, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.teacher_Portal = teacher_Portal;
            this.Text = teacher.Id + "";
            fillData();
        }

        public void fillData()
        {
            if (teacher != null)
            {
                lbName.Text = teacher.Name + " " + teacher.Surname;
                lbID.Text = ""+teacher.Id;
                lbSpr.Visible = false;
                lbDep.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else
            {
                lbName.Text = student.Name + " " + student.Surname;
                lbID.Text = "" + student.Id;
                lbSpr.Text = student.Advisor.Name + " " + student.Advisor.Surname;
                lbDep.Text = student.Department.Name;
            }
        }

        private void btnAccS_Click(object sender, EventArgs e)
        {
            if(teacher!=null)
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
            if (teacher != null)
                teacher_Portal.Enabled = true;
            else
                student_Portal.Enabled = true;
        }

        private void btnSbmtPass_Click(object sender, EventArgs e)
        {
                String oldPassword = txtOldP.Text;

                if ((teacher!=null && oldPassword != teacher.Password) || (teacher == null && oldPassword != student.Password))
                {
                    MessageBox.Show("Wrong old password");
                    return;
                }

                String newPassword = txtNwP.Text.Trim();

                if (newPassword != txtNwPC.Text.Trim())
                {
                    MessageBox.Show("Passwords doesn't match!");
                    return;
                }

                if (newPassword.Length < 6)
                {
                    MessageBox.Show("New password should be longer than 6 characters!");
                    return;
                }

                if (teacher != null)
                {
                    teacher.Password = newPassword;
                    TeacherDB.Update(teacher);
                }
                else
                {
                    student.Password = newPassword;
                    StudentDB.Update(student);
                }

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

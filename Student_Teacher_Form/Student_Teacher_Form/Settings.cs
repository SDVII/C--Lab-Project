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
        private SplitContainer sc;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Student student, Student_Portal student_Portal, SplitContainer sc)
        {
            InitializeComponent();
            this.student = student;
            this.student_Portal = student_Portal;
            this.Text = student.Id + "";
            this.sc = sc;
            try
            {
                pbPrf.Load("http://37.139.18.76:3010/images/stu/" + student.Id + ".jpeg");
            }
            catch (Exception)
            {
                //no image
            }

            fillData();
        }

        public Settings(Teacher teacher, Teacher_Portal teacher_Portal, SplitContainer sc)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.teacher_Portal = teacher_Portal;
            this.Text = teacher.Id + "";
            this.sc = sc;
            try
            {
                pbPrf.Load("http://37.139.18.76:3010/images/tea/" + teacher.Id + ".jpeg");
            }
            catch (Exception)
            {
                //no image
            }

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
                if (rbHide.Checked == true)
                {
                    sc.Panel2Collapsed = true;
                }
                else if (rbShow.Checked == true)
                {
                    sc.Panel2Collapsed = false;
                }
                this.Close();
                teacher_Portal.Enabled = true;
            }
            else
            {
                if (rbHide.Checked == true)
                {
                    sc.Panel2Collapsed = true;
                }
                else if (rbShow.Checked == true)
                {
                    sc.Panel2Collapsed = false;
                }

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
                    lbChanges.Visible = true;
                    lbChanges.Text = "Old Password is incorrect";
                    lbChanges.ForeColor = Color.Red;
                    return;
                }

                String newPassword = txtNwP.Text.Trim();

                if (newPassword != txtNwPC.Text.Trim())
                {
                    lbChanges.Visible = true;
                    lbChanges.Text = "Passwords doesn't match";
                    lbChanges.ForeColor = Color.Red;
                    return;
                }

                if (newPassword.Length < 6)
                {
                    lbChanges.Visible = true;
                    lbChanges.Text = "Password must be at least 6 characters long";
                    lbChanges.ForeColor = Color.Red;
                    return;
                }

                if (teacher != null)
                {
                    teacher.Password = newPassword;
                    TeacherDB.Update(teacher);
                
                    lbChanges.Visible = true;
                    lbChanges.Text = "Password changed";
                    lbChanges.ForeColor = Color.Black;
                    return;
                }
                else
                {
                    student.Password = newPassword;
                    StudentDB.Update(student);
                    lbChanges.Visible = true;
                    lbChanges.Text = "Password changed";
                    lbChanges.ForeColor = Color.Black;
                    return;
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

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
        Teacher teacher = null;
        Student student = null;
        bool isTeacher = false;

        public Settings(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.isTeacher = true;

            lbName.Text = teacher.Name;
            lbID.Text = ""+teacher.Id;
            label4.Visible = false;
            label5.Visible = false;
            lbSpr.Visible = false;
            lbDep.Visible = false;
        }
        public Settings(Student student)
        {
            InitializeComponent();
            this.student = student;

            lbName.Text = student.Name;
            lbID.Text = "" + student.Id;
            lbSpr.Text = student.Advisor.Name;
            lbDep.Text = student.Department.Name;
            
        }

        private void btnAccS_Click(object sender, EventArgs e)
        {
            String oldPassword = txtOldP.Text;

            if ((isTeacher && oldPassword != teacher.Password) || (!isTeacher && oldPassword != student.Password))
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

            if (isTeacher)
            {
                teacher.Password = newPassword;
                TeacherDB.Update(teacher);
            }
            else
            {
                student.Password = newPassword;
                StudentDB.Update(student);
            }

            Application.Exit();
        }
    }
}

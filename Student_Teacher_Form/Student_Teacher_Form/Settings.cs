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
        private SplitContainer sc;

        public Settings(int stuID, Student_Portal student_Portal, SplitContainer sc)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
            this.sc = sc;

            //fill personal info form DB
        }

        public Settings(int teachID, Teacher_Portal teacher_Portal, SplitContainer sc)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";
            this.sc = sc;
        }

        private void btnAccS_Click(object sender, EventArgs e)
        {
            if(teachID!=0)
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
            if (teachID != 0)
                teacher_Portal.Enabled = true;
            else
                student_Portal.Enabled = true;
        }

        private void btnSbmtPass_Click(object sender, EventArgs e)
        {
            if (!txtOldP.Text.Equals("old pass")) //pass from db
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Old Password is incorrect";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (!txtNwP.Text.Equals(txtNwPC.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Passwords doesn't match";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                //change pass
                lbChanges.Visible = true;
                lbChanges.Text = "Password changed";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }
    }
}

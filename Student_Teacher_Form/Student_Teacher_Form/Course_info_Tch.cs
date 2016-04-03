using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{

    public partial class Course_info_Tch : Form
    {
        String filename;
        String path;
        String bName;
        String uName;
        Boolean bClicked = false;
        Boolean uClicked = false;

        private Course course;
        private Teacher teacher;
        private Teacher_Portal teacher_Portal;


        public Course_info_Tch(Course course, Teacher teacher, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            lbCrsCd.Text = course.Name;
            this.teacher = teacher;
            this.teacher_Portal = teacher_Portal;
            this.course = course;

            pouplateCourses(cbCrsEx);
            //cbCrsEx.SelectedIndex = 0;
        }

        private void pouplateCourses(ComboBox cbCrsEx)
        {
            /*
            for (int i = 0; i < number of courses; i++)
            {
                cbCrsEx.Items.Add(courses);
            }
            */
        }

        private void btnBrwsD_Click(object sender, EventArgs e)
        {
            bClicked = true;
            var btn = (Button)sender;
            bName = btn.Name;

        }

        private void btnUpD_Click(object sender, EventArgs e)
        {
            uClicked = true;
            var btn = (Button)sender;
            uName = btn.Name;
        }

        private void Course_info_Tch_Enter(object sender, EventArgs e)
        {
            if (bClicked == true)
            {
                ofd.Title = "Attach File";
                ofd.InitialDirectory = @"C:\";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = System.IO.Path.GetFileName(ofd.FileName);
                    path = System.IO.Path.GetDirectoryName(ofd.FileName);
                    if (bName.Equals(btnBrwsD.Name))
                        txtPathD.Text = path + "//" + filename;
                    else
                        txtPathM.Text = path + "//" + filename;
                }
                bClicked = false;
                bName = "";
            }

            if (uClicked == true)
            {
                if (!Utilities.NullOrEmpty(txtPathD.Text))
                {
                    WebClient wc = new WebClient();
                    NetworkCredential nc = new NetworkCredential("", "");
                    Uri url;
                    if (uName.Equals(btnUpD.Name))
                    {
                        url = new Uri(@"" + filename);
                    }
                    else
                    {
                        url = new Uri(@"" + filename);
                    }
                    wc.Credentials = nc;
                    byte[] arrReturn = wc.UploadFile(url, txtPathD.Text);
                    MessageBox.Show(arrReturn.ToString());
                }
                uClicked = false;
                uName = "";
            }
        }

        private void btnAccCrsInTch_Click(object sender, EventArgs e)
        {
            teacher_Portal.Enabled = true;
            this.Close();
        }

        private void Course_info_Tch_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacher_Portal.Enabled = true;
        }

        private void btnSbmCM_Click(object sender, EventArgs e)
        {
            if (Utilities.NullOrEmpty(txtTtCM.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Title is missing";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (Utilities.NullOrEmpty(tbBdyCM.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Body is missing";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                lbChanges.Visible = true;
                //send message
                lbChanges.Text = "Message sent";
                lbChanges.ForeColor = Color.Black;
            }
        }

        private void btnSbmtEx_Click(object sender, EventArgs e)
        {
            if (cbCrsEx.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a course";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                //save to DB
                //string theDate = dtpEx.Value.ToString("yyyy-MM-dd"); to get date value
                lbChanges.Visible = true;
                lbChanges.Text = "Exam date submitted";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }

    }
}

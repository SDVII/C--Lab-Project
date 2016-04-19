using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            String location = txtPathD.Text;//file location
            //checks for file
            if (!File.Exists(location))
            {
                MessageBox.Show("There is no such file!");
                return;
            }
            if (new FileInfo(location).Length > (1024 * 1024 * 25))
            {
                MessageBox.Show("File size can't be bigger than 25 MB!");
                return;
            }

            //Create and add to db
            String name = Path.GetFileName(location);
            String info = txtInfoD.Text;
            int id = CourseFileDB.Add(new CourseFile(name, info, DateTime.Now, teacher, course));

            //upload
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("id", "TTR");
            nvc.Add("btn-submit-file", "Upload");
            BackendHandler.HttpUploadFile("http://37.139.18.76:3010/coursefileupload", id, @location, "file", "multipart/form-data", nvc, uploadResult);
            //http://csproject.ml/coursefileupload
        }

        private void uploadResult(String s, int id)
        {
            switch (s)
            {
                case "success":
                    MessageBox.Show("File upload was successful!");
                    break;
                case "error":
                    MessageBox.Show("There was a problem while connecting to server. Please try again later!");
                    CourseFileDB.Delete(id);
                    break;
                case "servererror":
                    MessageBox.Show("There was a problem within the server. Please try again later! ");
                    CourseFileDB.Delete(id);
                    break;
            }
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
                CourseAnnouncements coa = new CourseAnnouncements(teacher.Id, course.Id, txtTtCM.Text, tbBdyCM.Text, DateTime.Now);
                CourseAnnouncementsDB.Add(coa);
                lbChanges.Visible = true;
                //send message
                lbChanges.Text = "Message sent";
                lbChanges.ForeColor = Color.Black;
            }
        }

        private void btnSbmtEx_Click(object sender, EventArgs e)
        {
            if (Utilities.NullOrEmpty(txtPlace.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please enter a location for the exam.";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                //save to DB
                string theDate = dtpEx.Value.ToString("yyyy-MM-dd hh:mm")+":00";
                Exam exam = new Exam(course.Id, theDate, txtPlace.Text);
                ExamDB.Add(exam);

                lbChanges.Visible = true;
                lbChanges.Text = "Exam date submitted";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

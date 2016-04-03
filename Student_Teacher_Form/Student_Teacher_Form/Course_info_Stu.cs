using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{
    public partial class Course_info_Stu : Form
    {
        private Student_Portal student_Portal;
        private Course course;

        public Course_info_Stu(Course course, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.course = course;
            this.student_Portal = student_Portal;
            lbCrsCd.Text = course.Name;

            populateCourseinfo();
            populateMessages();
            populateAttachments();

        }

        private void populateAttachments()
        {

            /*
            for (int i = 0; i < attachments in db ; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvAtch.Rows[i].Clone();
                String title = "";
                String instructor = "";
                LinkLabel ll = new LinkLabel();
                ll.AutoSize = true;
                ll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                ll.Name = "ll";
                ll.TabStop = true;
                ll.Text = "file name";
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = "link to the file";
                ll.Links.Add(link);
                ll.LinkClicked += new LinkLabelLinkClickedEventHandler(downloadLink);

                row.Cells[0].Value = title;
                row.Cells[1].Value = instructor;
                row.Cells[2].Value = ll;
                dgvAtch.Rows.Add(row);
            }
            */


        }

        private void downloadLink(object sender, LinkLabelLinkClickedEventArgs  e)
        {
            LinkLabel ll = (LinkLabel)sender;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            ll.LinkVisited = true;
        }


         private void populateMessages()
        {
            List<CourseAnnouncements> coAnnoList = CourseAnnouncementsDB.GetWithCourseId(course.Id);

            foreach(CourseAnnouncements co in coAnnoList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = co.Title;
                lvi.SubItems.Add(co.Time.ToShortDateString());
                lvi.SubItems.Add(co.Teacher.Name + " " + co.Teacher.Surname);
                lvi.SubItems.Add(co.Msg);
                lvMsg.Items.Add(lvi);
            }
        }

        private void populateCourseinfo()
        {
            lbName.Text = course.Name;
            lbDep.Text = course.Department.Name;
            lbCode.Text = course.Code;
            //pbTchrP.Image = "";
            //bTchrP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           
        }

        private void Course_info_Stu_Load(object sender, EventArgs e)
        {
            lvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAccCrsInStu_Click(object sender, EventArgs e)
        {
            //save changes to DB
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Course_info_Stu_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }        
    }
}

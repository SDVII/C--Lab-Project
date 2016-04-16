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
        private List<CourseFile> fileList;

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
            fileList = CourseFileDB.GetWithCourseId(course);

            
            for (int i = 0; i < fileList.Count ; i++)
            {
                Console.WriteLine(fileList[i].Name);
                DataGridViewRow row = (DataGridViewRow)dgvAtch.Rows[i].Clone();
                String title = fileList[i].Name;
                String info = fileList[i].Info;
                LinkLabel ll = new LinkLabel();
                ll.AutoSize = true;
                ll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                ll.Name = "ll";
                ll.TabStop = true;
                ll.Text = "file link";
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = "http://csproject.ml/course/"+ fileList[i].Id+"-"+ fileList[i].Name;
                ll.Links.Add(link);
                ll.LinkClicked += new LinkLabelLinkClickedEventHandler(downloadLink);
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = "http://csproject.ml/course/" + fileList[i].Id + "-" + fileList[i].Name;

                row.Cells[0].Value = title;
                row.Cells[1].Value = info;
                row.Cells[2] = linkCell;
                dgvAtch.Rows.Add(row);
            }


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

        private void dgvAtch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                System.Diagnostics.Process.Start("http://csproject.ml/course/" + fileList[e.RowIndex].Id + "-" + fileList[e.RowIndex].Name);
            }
        }
    }
}

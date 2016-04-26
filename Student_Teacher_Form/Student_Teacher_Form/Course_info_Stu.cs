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
        private Teacher teacher;
        private List<CourseFile> fileList;

        public Course_info_Stu(Teacher teacher,Course course, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.course = course;
            this.teacher = teacher;
            this.student_Portal = student_Portal;
            lbCrsCd.Text = course.Name;

            populateCourseinfo();
            populateMessages();
            populateAttachments();

        }

        private void populateAttachments()
        {
            fileList = CourseFileDB.GetWithCourseId(course);

            
            for (int i = 0; i < fileList.Count ; i++) //Dianmically adding attachments
            {
                Console.WriteLine(fileList[i].Name);
                DataGridViewRow row = (DataGridViewRow)dgvAtch.Rows[i].Clone();
                String title = fileList[i].Name;
                String info = fileList[i].Info;
                var ll = new DataGridViewLinkCell();
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = "http://37.139.18.76:3010/course/" + fileList[i].Id + "-" + fileList[i].Name;

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
            AnnoStack stack = CourseAnnouncementsDB.GetWithCourseId(course.Id);

            while (stack.Top != null) //Dianmically adding Announcements
            {
                 ListViewItem lvi = new ListViewItem();
                 lvi.Text = stack.Top.Title;
                 lvi.SubItems.Add(stack.Top.Time.ToShortDateString());
                 lvi.SubItems.Add(stack.Top.Teacher.Name + " " + stack.Top.Teacher.Surname);
                 lvi.SubItems.Add(stack.Top.Msg);
                 lvMsg.Items.Add(lvi);
                stack.pop();
            }
        }

        private void populateCourseinfo()
        {
            try
            {
                lbName.Text = teacher.Name + " " + teacher.Surname;
            }
            catch(Exception e1)
            {
                lbName.Text = "not mentioned";
            }
            lbDep.Text = course.Department.Name;
            lbCode.Text = course.Code;
            try {
                pbTchrP.Load("http://37.139.18.76:3010/images/tea/" + teacher.Id + ".jpeg");
            }
            catch (Exception e2)
            {
                //nothing
            }
            pbTchrP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           
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
                System.Diagnostics.Process.Start("http://37.139.18.76:3010/course/" + fileList[e.RowIndex].Id + "-" + fileList[e.RowIndex].Name);
            }
        }

    }
}

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
    public partial class Student_Portal : Form
    {

    
        private Student student;
        List<StudentSchedule> stuScheduleList;
        List<Section> sectionList;
        List<SectionTime> sectionTimeList;
        List<Course> courseList;
        //List<Msg> msgList;
        List<Announcement> annoList;
        //List<CourseAnnouncements> coAnnoList;
        private bool clicked = false;
            
        public Student_Portal(Student student)
        {
            InitializeComponent();
            this.student = student;
            this.Text = student.Id + "";
            lbName.Text = student.Name + " " + student.Surname;
            lbID.Text = student.Id + "";
            fetchData();

            body.Panel1Collapsed = true;

            foreach (DataGridViewRow r in dgvCourses.Rows) //To set the column hight!
            {
                r.Height = 30;
            }


            populateCourses(dgvCourses);
            populateSchedule(lvSchedule);
            populateNotification(lbNotification);
        }

        private void fetchData()
        {
            //Student Schedule List
            stuScheduleList = StudentScheduleDB.GetWithStudentId(student.Id);

            //course and section List
            courseList = new List<Course>();
            sectionList = new List<Section>();
            foreach(StudentSchedule ss in stuScheduleList)
            {
                courseList.Add(CourseDB.Get(ss.CourseId));
                sectionList.Add(SectionDB.Get(ss.SectionId));
            }

            //sectionTime List
            sectionTimeList = new List<SectionTime>();
            foreach(Section s in sectionList)
            {
                sectionTimeList.AddRange(SectionTimeDB.GetWithSectionId(s.Id));
            }


            //Msg list


            //Announcements list
            annoList = AnnouncementDB.GetLimited(15);
            
        }

        private void populateNotification(ListBox lbNotification)
        {

            for (int i = 0; i < annoList.Count; i++)
            {              

                lbNotification.Items.Add(annoList[i].Title);
                lbNotification.Items.Add("---------------------");
            }
        }//f*ck you houmam  -Hani

        private void populateSchedule(ListView lvSchedule)
        {
            int currentDay = (int)DateTime.Now.DayOfWeek;
            List<SectionTime> todaysList = new List<SectionTime>();

            foreach(SectionTime sc in sectionTimeList)
            {
                Console.WriteLine((sc.Time / 17 + 1) + "--" + sc.getTimeAsString());
                if ((sc.Time / 17 + 1) == currentDay)
                {
                    
                    todaysList.Add(sc);
                }
            }

            for(int i = 0; i < todaysList.Count; i++)
            {
                for(int j = 0; j < todaysList.Count - 1; j++)
                {
                    if(todaysList[j].Time> todaysList[j+1].Time)
                    {
                        SectionTime temp = todaysList[j+1];
                        todaysList[j + 1] = todaysList[j];
                        todaysList[j] = temp;
                    }
                }
            }
            
            for (int i = 0; i < todaysList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = todaysList[i].Section.Course.Name;
                lvi.SubItems.Add(todaysList[i].getTimeAsString());
                lvi.SubItems.Add(todaysList[i].Location);
                lvSchedule.Items.Add(lvi);
            }
        }

        private void populateCourses(DataGridView dgvCourses)
        {
            // For populating course GridViewList. just replace the counter and course name

            for (int i = 0; i < courseList.Count; i++)
            {
                var btn = new DataGridViewButtonColumn();
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Name = "btn_" + i;
                Console.WriteLine(courseList[i].Name);
                btn.UseColumnTextForButtonValue = true;
                btn.Text = courseList[i].Name;
                dgvCourses.Rows.Add(btn);
                dgvCourses[0, i].Value = courseList[i].Name; //for the renamming
            }
        }


        private void Student_Portal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void callCourse(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Course_info_Stu f = new Course_info_Stu(null, this);
            f.Visible = true;
            this.Enabled = false;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                body.Panel1Collapsed = false;
                clicked = true;
            }
            else
            {
                body.Panel1Collapsed = true;
                clicked = false;
        }
    }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            this.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings f = new Settings(student, this, middle_events);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule f = new Schedule(student, sectionTimeList, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnAddCrs_Click(object sender, EventArgs e)
        {
            Course_Add f = new Course_Add(student.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnReqDoc_Click(object sender, EventArgs e)
        {
            Document_Request f = new Document_Request(student.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void brnEx_Click(object sender, EventArgs e)
        {
            Exam_Schedule f = new Exam_Schedule(courseList, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnFinAff_Click(object sender, EventArgs e)
        {
            Financial_Affairs f = new Financial_Affairs(student.FinancialAffairs, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            Report_Issue f = new Report_Issue(student.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact_Us f = new Contact_Us(this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnTranscript_Click(object sender, EventArgs e)
        {
            Transcript f = new Transcript(student.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void lbNotification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var list = (ListBox)sender;

            // This is your selected item
            if(list.SelectedIndex%2==0)
                MessageBox.Show(annoList[list.SelectedIndex / 2].Msg, annoList[list.SelectedIndex / 2].Title);
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            Course_info_Stu f = new Course_info_Stu(courseList[e.RowIndex], this);
            f.Visible = true;
            this.Enabled = false;

        }
    }
}

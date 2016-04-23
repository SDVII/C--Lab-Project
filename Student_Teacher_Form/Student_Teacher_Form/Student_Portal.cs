using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{
    public partial class Student_Portal : Form
    {

        BackgroundWorker bw = new BackgroundWorker();
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
            pnlCourses.HorizontalScroll.Maximum = 0;
            pnlCourses.AutoScroll = false;
            pnlCourses.VerticalScroll.Visible = false;
            pnlCourses.AutoScroll = true;
            fetchData();

            body.Panel1Collapsed = true;

            populateCourses(pnlCourses);
            populateSchedule(lvSchedule);
            populateNotification(lbNotification);
        }

        public void splashScreen()
        {
            Application.Run(new Loading());
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
        }

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

        private void populateCourses(Panel pnl)
        {
            // For populating course GridViewList. just replace the counter and course name

            for (int i = 0; i < courseList.Count; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(0, 30 * i);
                btn.Width = pnl.Width;
                btn.Height = 30;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
                btn.BackColor = System.Drawing.Color.White;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Calibri", 11.25F);
                btn.ForeColor = System.Drawing.Color.Black;
                btn.UseVisualStyleBackColor = false;
                btn.Name = "btn_" + i;
                btn.Text = courseList[i].Name;
                btn.Click += new System.EventHandler(this.callCourse);
                pnl.Controls.Add(btn);
            }
        }


        private void Student_Portal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void callCourse(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Button btn = (Button)sender;
            string[] words = btn.Name.Split('_');
            int courseId = courseList[Convert.ToInt32(words[1])].Id;
            Teacher teacher = null;
            foreach (Section s in sectionList)
            {
                if (s.Course.Id == courseId)
                {
                    teacher = s.Teacher;
                    break;
                }
            }
            Course_info_Stu f = new Course_info_Stu(teacher, courseList[Convert.ToInt32(words[1])], this);
            f.Visible = true;
            this.Enabled = false;
            t.Abort();

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
            DialogResult r = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                Login f = new Login();
                f.Visible = true;
                this.Visible = false;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Settings f = new Settings(student, this, middle_events);
            f.Visible = true;
            this.Enabled = false;
            t.Abort();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Schedule f = new Schedule(student, sectionTimeList, this);
            f.Visible = true;
            this.Enabled = false;
            t.Abort();
        }

        private void btnAddCrs_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Course_Add f = new Course_Add(student, courseList, sectionList, this);
            f.Visible = true;
            this.Enabled = false;
            t.Abort();
           // MessageBox.Show("System is closed right now!");
        }

        private void btnReqDoc_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Document_Request f = new Document_Request(student.Id, this);
            f.Visible = true;
            this.Enabled = false;
            t.Abort();
        }

        private void brnEx_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Exam_Schedule f = new Exam_Schedule(courseList, this);
            f.Visible = true;
            this.Enabled = false;
            t.Abort();
        }

        private void btnFinAff_Click(object sender, EventArgs e)
        {

            Financial_Affairs f = new Financial_Affairs(student.Semester, student.FinancialAffairs, this);
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
            Transcript f = new Transcript(student.Id, student.Semester, this);
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

    }
}

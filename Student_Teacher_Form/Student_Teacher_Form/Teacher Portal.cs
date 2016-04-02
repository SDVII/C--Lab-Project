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
    public partial class Teacher_Portal : Form
    {
        private Teacher teacher;
        Boolean clicked = false;

        List<Section> sectionList;
        List<SectionTime> sectionTimeList;
        List<Course> courseList;
        List<Announcement> annoList;


        public Teacher_Portal(Teacher teacher)
        {
            //Please replace the name with the ID's matching Name and Surname
            InitializeComponent();
            this.teacher = teacher;
            lbName.Text = teacher.Name + " " + teacher.Surname;
            lbID.Text = teacher.Id + "";
            this.Text = teacher.Id + "";
            body.Panel1Collapsed = true;

            fetchData();

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

            //sectionlist

            sectionList = SectionDB.GetWithTeacherId(teacher.Id);


            //course List
            courseList = new List<Course>();
            foreach (Section s in sectionList)
            {

                Course c = CourseDB.Get(s.CourseId);
                bool b = true;
                foreach(Course co in courseList)
                {
                    if(co.Id == c.Id)
                    {
                        b = false;
                        break;
                    }
                }

                if (b) courseList.Add(c);
            }

            //sectionTime List
            sectionTimeList = new List<SectionTime>();
            foreach (Section s in sectionList)
            {
                sectionTimeList.AddRange(SectionTimeDB.GetWithSectionId(s.Id));
            }


            //anno list
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

            foreach (SectionTime sc in sectionTimeList)
            {
                Console.WriteLine((sc.Time / 17 + 1) + "--" + sc.getTimeAsString());
                if ((sc.Time / 17 + 1) == currentDay)
                {

                    todaysList.Add(sc);
                }
            }

            for (int i = 0; i < todaysList.Count; i++)
            {
                for (int j = 0; j < todaysList.Count - 1; j++)
                {
                    if (todaysList[j].Time > todaysList[j + 1].Time)
                    {
                        SectionTime temp = todaysList[j + 1];
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
                DataGridViewRow row = (DataGridViewRow)dgvCourses.Rows[i].Clone();
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.White;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.Black;
                btn.Name = "btn_" + i;
                Console.WriteLine(courseList[i].Name);
                btn.Text = courseList[i].Name;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new System.EventHandler(this.callCourse);
                row.Cells[0].Value = btn;
                dgvCourses.Rows.Add(row);
            }
        }

        private void callCourse(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Course_info_Tch f = new Course_info_Tch(teacher.Id, this, btn.Text);
            f.Visible = true;
            this.Enabled = false;

        }

        private void Teacher_Portal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            this.Visible = false;
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

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule f = new Schedule(teacher, sectionTimeList, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnSrchStu_Click(object sender, EventArgs e)
        {
            Search_Students f = new Search_Students(teacher.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void brnSndReq_Click(object sender, EventArgs e)
        {
            Send_Request f = new Send_Request(teacher.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact_Us f = new Contact_Us(teacher.Id, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings f = new Settings(teacher, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void lbNotification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var list = (ListBox)sender;

            // This is your selected item
            if (list.SelectedIndex % 2 == 0)
                MessageBox.Show(annoList[list.SelectedIndex / 2].Msg, annoList[list.SelectedIndex / 2].Title);
        }
    }
}

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
        private int stuID;
        private String name;
        private bool clicked = false;

        public Student_Portal(int stuID , String name)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.name = name;
            this.Text = stuID + "";
            lbName.Text = name;
            lbID.Text = stuID + "";

            body.Panel1Collapsed = true;

            foreach (DataGridViewRow r in dgvCourses.Rows) //To set the column hight!
            {
                r.Height = 30;
            }

            populateCourses(dgvCourses);
            populateSchedule(lvSchedule);
            populateNotification(lbNotification);
        }

        private void populateNotification(ListBox lbNotification)
        {
            /*
            for (int i = 0; i < number of notifications; i++)
            {
                lbNotification.Items.Add(notifications);
                lbNotification.Items.Add("-------------------------------------------");
            }
            */
        }

        private void populateSchedule(ListView lvSchedule)
        {
            /*
            for (int i = 0; i < number of courses; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = Course name;
                lvi.SubItems.Add(Course time);
                lvi.SubItems.Add(Course location);
                lvSchedule.Items.Add(lvi);
            }
            */
        }

        private void populateCourses(DataGridView dgvCourses)
        {
            /* For populating course GridViewList. just replace the counter and course name

            for (int i = 0; i < courses in db ; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvCourses.Rows[i].Clone();
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.White;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.Black;
                btn.Name = "btn_" + i;
                btn.Text = "Name of the course";
                btn.UseVisualStyleBackColor = false;
                btn.Click += new System.EventHandler(this.callCourse);
                row.Cells[0].Value = btn;
                dgvCourses.Rows.Add(row);
            }
            */
        }


        private void Student_Portal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void callCourse(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Course_info_Stu f = new Course_info_Stu(stuID, this, btn.Text);
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
            Settings f = new Settings(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule f = new Schedule(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnAddCrs_Click(object sender, EventArgs e)
        {
            Course_Add f = new Course_Add(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnReqDoc_Click(object sender, EventArgs e)
        {
            Document_Request f = new Document_Request(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void brnEx_Click(object sender, EventArgs e)
        {
            Exam_Schedule f = new Exam_Schedule(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnFinAff_Click(object sender, EventArgs e)
        {
            Financial_Affairs f = new Financial_Affairs(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            Report_Issue f = new Report_Issue(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact_Us f = new Contact_Us(stuID, this);
            f.Visible = true;
            this.Enabled = false;
        }
    }
}

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
        private int teachID;
        private String name;
        Boolean clicked = false;
        

        public Teacher_Portal(int teachID, string name)
        {
            //Please replace the name with the ID's matching Name and Surname
            InitializeComponent();
            this.teachID = teachID;
            this.name = name;
            lbName.Text = name;
            lbID.Text = teachID + "";
            this.Text = teachID + "";
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

        private void callCourse(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Course_info_Tch f = new Course_info_Tch(teachID, this, btn.Text);
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
            Schedule f = new Schedule(teachID , this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnSrchStu_Click(object sender, EventArgs e)
        {
            Search_Students f = new Search_Students(teachID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void brnSndReq_Click(object sender, EventArgs e)
        {
            Send_Request f = new Send_Request(teachID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact_Us f = new Contact_Us(teachID, this);
            f.Visible = true;
            this.Enabled = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings f = new Settings(teachID, this);
            f.Visible = true;
            this.Enabled = false;
        }
    }
}

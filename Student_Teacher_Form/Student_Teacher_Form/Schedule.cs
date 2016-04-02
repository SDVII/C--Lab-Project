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
    public partial class Schedule : Form
    {
        private int teachID = 0;
        private Teacher_Portal teacher_Portal;
        private int stuID = 0;
        private Student_Portal student_Portal;

        public Schedule(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";

            populateSchedule(lvSchd);
        }

        private void populateSchedule(ListView lvSchd)
        {
            /*
             for (int i = 0; i < date and day; i++)
             {
                 ListViewItem lvi = new ListViewItem();
                 lvi.Text = date;
                 lvi.SubItems.Add(mon);
                 lvi.SubItems.Add(tue);
                 lvi.SubItems.Add(wen);
                 lvi.SubItems.Add(thr);
                 lvi.SubItems.Add(fri);
                 lvi.SubItems.Add(sat);
                 lvi.SubItems.Add(sun);
                 lvSchedule.Items.Add(lvi);
             }
             */
        }

        public Schedule(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(teachID != 0)
                teacher_Portal.Enabled = true;
            else
                student_Portal.Enabled = true;
        }

        private void btnAccSchd_Click(object sender, EventArgs e)
        {
            if (teachID != 0)
            {
                this.Close();
                teacher_Portal.Enabled = true;
            }
            else
            {
                this.Close();
                student_Portal.Enabled = true;
            }
        }
    }
}

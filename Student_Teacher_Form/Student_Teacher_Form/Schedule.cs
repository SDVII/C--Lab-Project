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
        private Teacher teacher = null;
        private Teacher_Portal teacher_Portal;
        private Student student = null;
        private Student_Portal student_Portal;
        private List<SectionTime> sectionTimeList;

        public Schedule(Teacher teacher, List<SectionTime> sectionTimeList, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.sectionTimeList = sectionTimeList;
            this.teacher_Portal = teacher_Portal;
            this.Text = teacher.Id + "";

            populateSchedule(lvSchd);
        }
        public Schedule(Student student, List<SectionTime> sectionTimeList, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.student = student;
            this.sectionTimeList = sectionTimeList;
            this.student_Portal = student_Portal;
            this.Text = student.Id + "";

            populateSchedule(lvSchd);
        }

        private void populateSchedule(ListView lvSchd)
        {            
            for(int  i = 0; i < 17; i++)
            {
                SectionTime[] arr = new SectionTime[7];
                for(int j = 0; j < sectionTimeList.Count; j++)
                {
                    if (sectionTimeList[j].Time % 17 - 1 == i)
                    {
                        arr[sectionTimeList[j].Time / 17] = sectionTimeList[j];
                    }                 
                    
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (8 + i) + ":30";
                for (int k = 0; k < 7; k++)
                {
                    if (arr[k] != null)
                        lvi.SubItems.Add(arr[k].Section.Course.Name + "(" + arr[k].Location + ")");
                    else
                        lvi.SubItems.Add("");
                }
                lvSchd.Items.Add(lvi);
            }
        }
        

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(teacher != null)
                teacher_Portal.Enabled = true;
            else
                student_Portal.Enabled = true;
        }

        private void btnAccSchd_Click(object sender, EventArgs e)
        {
            if (teacher != null)
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

        private void lvSchd_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}

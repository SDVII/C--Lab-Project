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
    public partial class Exam_Schedule : Form
    {
        private List<Course> courceList;
        private List<Exam> examList;
        private Student_Portal student_Portal;

        public Exam_Schedule(List<Course> courceList, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.courceList = courceList;
            this.student_Portal = student_Portal;

            populateExams(lvExSchd);
        }

        private void populateExams(ListView lvExSchd)
        {
            examList = new List<Exam>();
            foreach(Course c in courceList)
            {
                examList.AddRange(ExamDB.GetWithCourseId(c));
            }
            for (int i = 0; i < examList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = examList[i].Course.Code;
                lvi.SubItems.Add(examList[i].Time);
                lvi.SubItems.Add(examList[i].Place);
                lvExSchd.Items.Add(lvi);
            }
        }

        private void btnAccExSchd_Click(object sender, EventArgs e)
        {
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Exam_Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

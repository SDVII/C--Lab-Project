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
    public partial class Transcript : Form
    {
        private int stuID, stuSemester;
        private Student_Portal student_Portal;

        public Transcript(int stuID, int stuSemester, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.stuSemester = stuSemester;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";

            populateYear(cbYear);
            populateSemester(cbSemster);
            //cbYear.SelectedIndex = 0;
            //cbSemster.SelectedIndex = 0;
        }

        private void populateSemester(ComboBox cbSemster)
        {
            /*
           for (int i = 0; i < number of semsters; i++)
           {
               cbSemster.Items.Add(semster);
           }
           */
        }

        private void populateYear(ComboBox cbYear)
        {
            
           for (int i = 1; i <= ((stuSemester+1)/2); i++)
           {
               cbYear.Items.Add(""+i);
           }
        }

        private void btnSbmSem_Click(object sender, EventArgs e)
        {
            searchForTranscript(lvGrades);
        }

        private void searchForTranscript(ListView lvGrades)
        {
            lvGrades.Items.Clear();
            int semester = cbYear.SelectedIndex * 2 + cbSemster.SelectedIndex + 1;
            if (semester < stuSemester)
            {
                List<Slot> slotList = SlotDB.GetWithStudentId(stuID, semester);
                for (int i = 0; i < slotList.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = slotList[i].CourseCode;
                    lvi.SubItems.Add(slotList[i].TeacherName);
                    lvi.SubItems.Add(slotList[i].SlotResult);
                    lvGrades.Items.Add(lvi);
                }
            }
            else {
                MessageBox.Show("You haven't finished that semester yet!");
            }

             
        }

        private void btnAccTrn_Click(object sender, EventArgs e)
        {
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Transcript_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

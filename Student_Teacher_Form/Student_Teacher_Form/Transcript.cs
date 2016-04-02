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
        private int stuID;
        private Student_Portal student_Portal;

        public Transcript(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
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
            /*
           for (int i = 0; i < number of years; i++)
           {
               cbYear.Items.Add(year);
           }
           */
        }

        private void btnSbmSem_Click(object sender, EventArgs e)
        {
            searchForTranscript(lvGrades);
        }

        private void searchForTranscript(ListView lvGrades)
        {
            /*
             for (int i = 0; i < number of grades; i++)
             {
                 ListViewItem lvi = new ListViewItem();
                 lvi.Text = Course name;
                 lvi.SubItems.Add(instructor);
                 lvi.SubItems.Add(grade);
                 lvSchedule.Items.Add(lvi);
             }
             */
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

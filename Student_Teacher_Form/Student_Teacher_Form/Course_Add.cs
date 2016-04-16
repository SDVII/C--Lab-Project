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
    public partial class Course_Add : Form
    {
        private Student_Portal student_Portal;
        private Student student;
        private List<Course> courseListCur, courseListAva;

        public Course_Add(Student student, List<Course> courseList, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.student = student;
            this.courseListCur = courseList;
            this.student_Portal = student_Portal;
            this.Text = student.Id + "";

            populateAvailableCourses(lbAvlC);
            populateCurrentCourses(lbCurC);
            populateSections(cbSections);
        }

        private void populateSections(ComboBox cbSections)
        {
            /*
            for (int i = 0; i < number of sections; i++)
            {
                cbSections.Items.Add(sections);
            }
            */
        }

        private void populateCurrentCourses(ListBox lbCurC)
        {
            /*
            for (int i = 0; i < number of courses; i++)
            {
                lbCurC.Items.Add(courses);
            }
            */
        }

        private void populateAvailableCourses(ListBox lbAvlC)
        {
            /*
            for (int i = 0; i < number of courses; i++)
            {
                lbAvlC.Items.Add(courses);
            }
            */
        }

        private void btnAccC_Click(object sender, EventArgs e)
        {
            //save changes from lbCurC to db
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Course_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {

            if (lbAvlC.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a course";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                for (int i = 0; i < lbCurC.Items.Count; i++)
                {
                    if (lbCurC.Items[i].Equals(lbAvlC.SelectedValue))
                    {
                        lbChanges.Visible = true;
                        lbChanges.Text = "This course is already added";
                        lbChanges.ForeColor = Color.Red;
                        return;
                    }
                    else
                    {

                        if (cbSections.SelectedIndex == -1)
                        {
                            lbChanges.Visible = true;
                            lbChanges.Text = "Please select a section";
                            lbChanges.ForeColor = Color.Red;
                            return;
                        }
                        else
                        {
                            lbChanges.Visible = true;
                            lbCurC.Items.Add(lbAvlC.SelectedItem + " : " + cbSections.SelectedText);
                            lbChanges.Text = "Course added";
                            lbChanges.ForeColor = Color.Black;
                            return;
                        }
                    }
                }
            }
        }

        private void btnRmvC_Click(object sender, EventArgs e)
        {
            if (lbCurC.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a course";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                lbChanges.Visible = true;
                lbCurC.Items.RemoveAt(lbCurC.SelectedIndex);
                lbChanges.Text = "Course added";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }
    }
}

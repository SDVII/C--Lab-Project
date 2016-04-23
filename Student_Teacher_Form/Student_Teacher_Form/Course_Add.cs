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
        private List<Course> courseListCur, courseListAva, oldList;
        private List<Section> allSections, currSections, selectedSections;

        public Course_Add(Student student, List<Course> courseList, List<Section> sectionList,Student_Portal student_Portal)
        {
            InitializeComponent();
            this.student = student;
            this.oldList = new List<Course>();
            oldList.AddRange(courseList);
            this.courseListCur = courseList;
            this.selectedSections = sectionList;
            this.student_Portal = student_Portal;
            this.Text = student.Id + "";

            allSections = SectionDB.GetAll();
            currSections = new List<Section>();

            courseListAva = CourseDB.GetWithDepartmentId(student.Department.Id);

            foreach (Course c in courseListCur) {
                foreach (Course ca in courseListAva) {
                    if(c.Id == ca.Id)
                    {
                        courseListAva.Remove(ca);
                        break;
                    }
                }
            }


            populateAvailableCourses(lbAvlC);
            populateCurrentCourses(lbCurC);
            //populateSections(cbSections);
        }

        private void populateSections()
        {
            currSections.Clear();
            cbSections.Items.Clear();

            foreach(Section s in allSections)
            {
                if (s.CourseId == courseListAva[lbAvlC.SelectedIndex].Id)
                {
                    currSections.Add(s);
                }
            }
            
            for (int i = 0; i < currSections.Count; i++)
            {
                cbSections.Items.Add(currSections[i].Number);
            }
            
        }

        private void populateCurrentCourses(ListBox lbCurC)
        {
            
            for (int i = 0; i < courseListCur.Count; i++)
            {
                lbCurC.Items.Add(courseListCur[i].Name);
            }
            
        }

        private void populateAvailableCourses(ListBox lbAvlC)
        {
            for (int i = 0; i < courseListAva.Count; i++)
            {
                lbAvlC.Items.Add(courseListAva[i].Name);
            }
        }

        private void btnAccC_Click(object sender, EventArgs e)
        {
            //save changes from lbCurC to db

            //ADD THE NEW ONES
            for(int i = 0; i < courseListCur.Count; i++)
            {
                Boolean check = false;
                for(int j = 0; j < oldList.Count; j++)
                {
                    if(oldList[j].Id == courseListCur[i].Id)
                    {
                        Console.WriteLine("Here1!");
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    
                    StudentSchedule ss = new StudentSchedule(student.Id, selectedSections[i].TeacherId, courseListCur[i].Id, selectedSections[i].Id);
                    StudentScheduleDB.Add(ss);
                    Console.WriteLine("Here2!");
                }
            }

            //REMOVE
            for (int i = 0; i < oldList.Count; i++) {
                Boolean check = false;
                for(int j = 0; j < courseListCur.Count; j++)
                {
                    if (oldList[i].Id == courseListCur[j].Id)
                    {
                        check = true;
                        break;
                    }
                }

                if (!check)
                {
                    StudentScheduleDB.DeleteWithStudentIdAndCourseId(student.Id, oldList[i].Id);
                } 
            }

            //
            MessageBox.Show("For changes to happen, please login again!");
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Course_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }

        private void lbAvlC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvlC.SelectedIndices.Count > 0)
                populateSections();
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
            else if (cbSections.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a section";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                Boolean check = false;
                for (int i = 0; i < lbCurC.Items.Count; i++)
                {
                    if (lbCurC.Items[i].Equals(lbAvlC.SelectedValue))
                    {
                        lbChanges.Visible = true;
                        lbChanges.Text = "This course is already added";
                        check = true;
                        lbChanges.ForeColor = Color.Red;
                        return;
                    }  
                        
                    }
                if (!check)
                {
                    lbChanges.Visible = true;
                    lbCurC.Items.Add(lbAvlC.SelectedItem);
                    courseListCur.Add(courseListAva[lbAvlC.SelectedIndex]);
                    selectedSections.Add(currSections[cbSections.SelectedIndex]);
                    courseListAva.RemoveAt(lbAvlC.SelectedIndex);
                    lbAvlC.Items.RemoveAt(lbAvlC.SelectedIndex);


                    currSections.Clear();
                    cbSections.Items.Clear();

                    lbChanges.Text = "Course added";
                    lbChanges.ForeColor = Color.Black;
                    return;
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
                courseListAva.Add(courseListCur[lbCurC.SelectedIndex]);
                lbAvlC.Items.Add(courseListCur[lbCurC.SelectedIndex].Name);
                courseListCur.RemoveAt(lbCurC.SelectedIndex);
                selectedSections.RemoveAt(lbCurC.SelectedIndex);
                lbCurC.Items.RemoveAt(lbCurC.SelectedIndex);
                lbChanges.Text = "Course added";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }
    }
}

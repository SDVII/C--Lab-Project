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
    public partial class Search_Students : Form
    {
        private Teacher_Portal teacher_Portal;
        private int teachID;
        private Student stu;
        List<Student> allStudents;

        public Search_Students(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";
            allStudents = StudentDB.GetAll();
            cbSrchTyp.SelectedIndex = 0;
        }

        private void Search_Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacher_Portal.Enabled = true;
        }

        private void btnAccSS_Click(object sender, EventArgs e)
        {
            this.Close();
            teacher_Portal.Enabled = true;
        }

        private void btnSrchS_Click(object sender, EventArgs e)
        {
            if (Utilities.NullOrEmpty(txtSrchK.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Searchbar is Empty";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (cbSrchTyp.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a search method";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                List<Student> resultList = new List<Student>();
                //search DB
                if (cbSrchTyp.SelectedIndex == 0)
                {

                    //name
                    // it works return a student object

                    foreach (Student s in allStudents)
                    {
                        if ((s.Name + " " + s.Surname).ToLower().Contains(txtSrchK.Text.ToLower()))
                        {
                            resultList.Add(s);
                            break;
                        }
                    }
                }
                else if (cbSrchTyp.SelectedIndex == 1)
                {
                    //id
                    int id = 0;
                    try
                    {
                        id = Convert.ToInt32(txtSrchK.Text);
                        foreach (Student s in allStudents)
                        {
                            if ((""+s.Id).Contains(""+id))
                            {
                                resultList.Add(s);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lbChanges.Visible = true;
                        lbChanges.Text = "Please enter a valid ID";
                        lbChanges.ForeColor = Color.Red;
                        return;
                    }                    
                }
                else {
                    //dep
                }

                if (resultList.Count == 1)
                {
                    searchResultInput(resultList[0]);
                } 
                
                lbChanges.Visible = false;
            }
        }

        private void searchResultInput(Student student)
        {
            //pbStuP.Image = "";
            lbName.Text = student.Name + " " + student.Surname;
            lbID.Text = ""+student.Id;
            lbDep.Text = ""+student.Department.Name;
            lbSpr.Text = ""+student.Advisor.Name + " " +  student.Advisor.Surname;
            lbGpa.Text = ""+student.Gpa;
            /*for (int i = 0; i < number of courses; i++)
            {
                lbCrsTkn.Items.Add("");
            }*/
        }
    }
}

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
        private int stuID;

        public Course_Add()
        {
            
        }

        public Course_Add(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
        }

        private void btnAccC_Click(object sender, EventArgs e)
        {
            //save changes to db
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Course_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

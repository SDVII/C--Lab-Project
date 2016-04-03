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
    public partial class Contact_Us : Form
    {
        
        private Teacher_Portal teacher_Portal = null;
        private Student_Portal student_Portal = null;

        public Contact_Us( Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teacher_Portal = teacher_Portal;
        }

        public Contact_Us(Student_Portal student_Portal)
        {
            InitializeComponent();
            this.student_Portal = student_Portal;
            number.Text = "539-001-2345";
            label8.Text = "help@bau.edu.tr";
            label10.Text = "BAU";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnAccR_Click(object sender, EventArgs e)
        {
            if (teacher_Portal != null)
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

        private void Contact_Us_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (teacher_Portal != null)
                teacher_Portal.Enabled = true;

            else
                student_Portal.Enabled = true;
        }
    }
}

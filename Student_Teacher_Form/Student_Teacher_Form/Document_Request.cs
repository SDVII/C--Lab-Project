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
    public partial class Document_Request : Form
    {
        private Student_Portal student_Portal;
        private int stuID;

        public Document_Request(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnClrD_Click(object sender, EventArgs e)
        {

        }

        private void btnAccD_Click(object sender, EventArgs e)
        {
            //submit changes to db
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Document_Request_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

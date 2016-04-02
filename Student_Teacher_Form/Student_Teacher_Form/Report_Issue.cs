﻿using System;
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
    public partial class Report_Issue : Form
    {
        private Student_Portal student_Portal;
        private int stuID;

        public Report_Issue(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
        }

        private void btnAccR_Click(object sender, EventArgs e)
        {
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Report_Issue_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

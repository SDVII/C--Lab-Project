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
    public partial class Student_Portal : Form
    {
        private int stuID;

        public Student_Portal(int stuID)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.Text = stuID + "";
        }

        private void Student_Portal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

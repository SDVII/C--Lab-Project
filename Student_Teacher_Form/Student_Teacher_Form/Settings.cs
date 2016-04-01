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
    public partial class Settings : Form
    {
        private Teacher_Portal teacher_Portal;
        private int teachID;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";
        }

        private void btnAccS_Click(object sender, EventArgs e)
        {
            this.Close();
            teacher_Portal.Enabled = true;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacher_Portal.Enabled = true;
        }
    }
}

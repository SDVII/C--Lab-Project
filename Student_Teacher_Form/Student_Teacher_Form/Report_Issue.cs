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

            populateCatagories(cbCtgR);
            //cbCtgR.SelectedIndex = 0;
        }

        private void populateCatagories(ComboBox cbCtgR)
        {
            /*
            for (int i = 0; i < number of catagories; i++)
            {
                cbCrsEx.Items.Add(catagories);
            }
            */
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

        private void btnSbmR_Click(object sender, EventArgs e)
        {
            if (Utilities.NullOrEmpty(txtTtlR.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Title is Empty";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (Utilities.NullOrEmpty(tbBdyR.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Body is Empty";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (cbCtgR.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Select a Catagory";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                //save to DB
                lbChanges.Visible = true;
                lbChanges.Text = "Report Submitted";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }
    }
}

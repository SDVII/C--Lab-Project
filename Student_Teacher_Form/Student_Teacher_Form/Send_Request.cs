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
    public partial class Send_Request : Form
    {
        private Teacher_Portal teacher_Portal;
        private int teachID;

        public Send_Request(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";
            cbCtgRq.SelectedIndex = 0;
        }

        private void Send_Request_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacher_Portal.Enabled = true;
        }

        private void btnAccRq_Click(object sender, EventArgs e)
        {
            this.Close();
            teacher_Portal.Enabled = true;
        }

        private void btnSbmRq_Click(object sender, EventArgs e)
        {
            if (Utilities.NullOrEmpty(txtTilRq.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Title is Empty";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (Utilities.NullOrEmpty(tbBdyRq.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Body is Empty";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                //send the message
                DatabaseHandler db = new DatabaseHandler();
                db.insertNewRequest(txtTilRq.Text,tbBdyRq.Text,cbCtgRq.SelectedItem.ToString());
                lbChanges.Visible = true;
                lbChanges.Text = "Request sent";
                lbChanges.ForeColor = Color.Black;
                return;
            }
        }
    }
}

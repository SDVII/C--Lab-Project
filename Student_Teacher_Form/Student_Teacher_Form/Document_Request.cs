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

            pouplateDocuments(cbDoc);
            populateShipmentOptions(cbDocS);
        }

        private void populateShipmentOptions(ComboBox cbDocS)
        {
            /*
            for (int i = 0; i < number of options; i++)
            {
                cbDocS.Items.Add(options);
            }
            */
        }

        private void pouplateDocuments(ComboBox cbDoc)
        {
            /*
            for (int i = 0; i < number of documents; i++)
            {
                cbDoc.Items.Add(Docs);
            }
            */
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (cbDoc.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Select the document";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (cbDocS.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Select the document";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (cbEng.Checked == false && cbTr.Checked == false)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a langauge";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Document request made";
                lbChanges.ForeColor = Color.Black;
                lbDocL.Items.Add(cbDoc.SelectedText + " : " + cbDocS.SelectedText + " : " + cbEng.Text + "," + cbTr.Text);
                return;
            }
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

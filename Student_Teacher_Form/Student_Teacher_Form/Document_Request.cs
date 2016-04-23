using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Student_Teacher_Form
{
    public partial class Document_Request : Form
    {
        private Student_Portal student_Portal;
        private int stuID;
        private List<List<String>> documentList;
        DatabaseHandler Db = new DatabaseHandler();

        public Document_Request(int stuID, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.Text = stuID + "";
            documentList = new List<List<string>>();

            populateReadyDocuments(lbRdyD);
        }

        private void populateReadyDocuments(ListBox lbRdyD)
        {
            List<List<String>> readyList = Db.getReadyDocuments(stuID);
            
            for (int i = 0; i < readyList.Count; i++)
            {
                lbRdyD.Items.Add(readyList[i][0]);
            }
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

                List<String> list = new List<string>() { cbDoc.Text, cbDocS.Text, (cbEng.Checked ? "TR" : "") + "-" + (cbTr.Checked? "ENG" : "")};
                documentList.Add(list);
               
                lbDocL.Items.Add(cbDoc.Text + " : " + cbDocS.Text + " : " + cbEng.Text + "," + cbTr.Text);
                return;
            }
        }

        private void btnClrD_Click(object sender, EventArgs e)
        {
            documentList.Clear();
            lbDocL.Items.Clear();
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

        private void btnSbmD_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lbDocL.Items.Count; i++)
            {
                List<String> list = documentList[i];
                Db.insertDocumentRequest(stuID, list[0], list[1], list[2]);
            }
            //add all items to DB
            lbDocL.Items.Clear();
            documentList.Clear();

        }

        private void btnRmvD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbDocL.SelectedItems.Count; i++)
            {
                documentList.RemoveAt(lbDocL.Items.IndexOf(lbDocL.SelectedItems[i]));
                lbDocL.Items.Remove(lbDocL.SelectedItems[i]);
                i--;
            }
        }
    }
}

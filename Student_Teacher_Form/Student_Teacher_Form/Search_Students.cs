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
    public partial class Search_Students : Form
    {
        private Teacher_Portal teacher_Portal;
        private int teachID;

        public Search_Students(int teachID, Teacher_Portal teacher_Portal)
        {
            InitializeComponent();
            this.teachID = teachID;
            this.teacher_Portal = teacher_Portal;
            this.Text = teachID + "";

            cbSrchTyp.SelectedIndex = 0;
        }

        private void Search_Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacher_Portal.Enabled = true;
        }

        private void btnAccSS_Click(object sender, EventArgs e)
        {
            this.Close();
            teacher_Portal.Enabled = true;
        }

        private void btnSrchS_Click(object sender, EventArgs e)
        {
            if (Utilities.NullOrEmpty(txtSrchK.Text))
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Searchbar is Empty";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else if (cbSrchTyp.SelectedIndex == -1)
            {
                lbChanges.Visible = true;
                lbChanges.Text = "Please select a search method";
                lbChanges.ForeColor = Color.Red;
                return;
            }
            else
            {
                //search DB
                searchResultInput(pbStuP, lbName, lbID, lbDep, lbSpr, lbGpa, lbCrsTkn);
                lbChanges.Visible = false;
            }
        }

        private void searchResultInput(PictureBox pbStuP, Label lbName, Label lbID, Label lbDep, Label lbSpr, Label lbGpa, ListBox lbCrsTkn)
        {
            /*
             pbStuP.Image = "";
            lbName.Text = "";
            lbID.Text = "";
            lbDep.Text = "";
            lbSpr.Text = "";
            lbGpa.Text = "";
            for (int i = 0; i < number of courses; i++)
            {
                lbCrsTkn.Items.Add("");
            }
            */
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{
    public partial class Course_info_Stu : Form
    {
        private Student_Portal student_Portal;
        private int stuID;
        private String cName;

        public Course_info_Stu(int stuID, Student_Portal student_Portal, string cName)
        {
            InitializeComponent();
            this.stuID = stuID;
            this.student_Portal = student_Portal;
            this.cName = cName;
            this.Text = stuID + "";
            lbCrsCd.Text = cName;

            populateTeacherinfo(lbName,lbF,pbTchrP);
            populateMessages(lvMsg);
            populateAttachments(dgvAtch);

        }

        private void populateAttachments(DataGridView dgvAtch)
        {

            /*
            for (int i = 0; i < attachments in db ; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvAtch.Rows[i].Clone();
                String title = "";
                String instructor = "";
                LinkLabel ll = new LinkLabel();
                ll.AutoSize = true;
                ll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                ll.Name = "ll";
                ll.TabStop = true;
                ll.Text = "file name";
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = "link to the file";
                ll.Links.Add(link);
                ll.LinkClicked += new LinkLabelLinkClickedEventHandler(downloadLink);

                row.Cells[0].Value = title;
                row.Cells[1].Value = instructor;
                row.Cells[2].Value = ll;
                dgvAtch.Rows.Add(row);
            }
            */


        }

        private void downloadLink(object sender, LinkLabelLinkClickedEventArgs  e)
        {
            LinkLabel ll = (LinkLabel)sender;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            ll.LinkVisited = true;
        }


         private void populateMessages(ListView lvMsg)
        {
            /*
            for (int i = 0; i < number of messages; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = title;
                lvi.SubItems.Add(date);
                lvi.SubItems.Add(instructor);
                lvi.SubItems.Add(message);
                lvSchedule.Items.Add(lvi);
            }
            */
        }

        private void populateTeacherinfo(Label lbName, Label lbF, PictureBox pbTchrP)
        {

            /*
            lbName.Text = "";
            lbF.Text = "";
            pbTchrP.Image = "";
            pbTchrP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            */
        }

        private void Course_info_Stu_Load(object sender, EventArgs e)
        {
            lvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAccCrsInStu_Click(object sender, EventArgs e)
        {
            //save changes to DB
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Course_info_Stu_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }
    }
}

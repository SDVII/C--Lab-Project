﻿namespace Student_Teacher_Form
{
    partial class Student_Portal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Portal));
            this.main = new System.Windows.Forms.SplitContainer();
            this.topMain = new System.Windows.Forms.SplitContainer();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.SplitContainer();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.SplitContainer();
            this.menu = new System.Windows.Forms.SplitContainer();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnRep = new System.Windows.Forms.Button();
            this.btnFinAff = new System.Windows.Forms.Button();
            this.btnReqDoc = new System.Windows.Forms.Button();
            this.brnEx = new System.Windows.Forms.Button();
            this.btnAddCrs = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.rights = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.middle_events = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.clCourses = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chCrs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lbNotification = new System.Windows.Forms.ListBox();
            this.lable7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.main.Panel1.SuspendLayout();
            this.main.Panel2.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topMain)).BeginInit();
            this.topMain.Panel1.SuspendLayout();
            this.topMain.Panel2.SuspendLayout();
            this.topMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttons)).BeginInit();
            this.buttons.Panel2.SuspendLayout();
            this.buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            this.body.Panel1.SuspendLayout();
            this.body.Panel2.SuspendLayout();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.menu.Panel1.SuspendLayout();
            this.menu.Panel2.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rights)).BeginInit();
            this.rights.Panel2.SuspendLayout();
            this.rights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.middle_events)).BeginInit();
            this.middle_events.Panel1.SuspendLayout();
            this.middle_events.Panel2.SuspendLayout();
            this.middle_events.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // main.Panel1
            // 
            this.main.Panel1.Controls.Add(this.topMain);
            // 
            // main.Panel2
            // 
            this.main.Panel2.Controls.Add(this.body);
            this.main.Size = new System.Drawing.Size(1180, 572);
            this.main.SplitterDistance = 53;
            this.main.TabIndex = 2;
            // 
            // topMain
            // 
            this.topMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.topMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.topMain.Location = new System.Drawing.Point(0, 0);
            this.topMain.Name = "topMain";
            // 
            // topMain.Panel1
            // 
            this.topMain.Panel1.Controls.Add(this.btnMenu);
            this.topMain.Panel1.Controls.Add(this.lbID);
            this.topMain.Panel1.Controls.Add(this.lbName);
            // 
            // topMain.Panel2
            // 
            this.topMain.Panel2.Controls.Add(this.buttons);
            this.topMain.Size = new System.Drawing.Size(1180, 53);
            this.topMain.SplitterDistance = 316;
            this.topMain.SplitterWidth = 1;
            this.topMain.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnMenu.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(11, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 39);
            this.btnMenu.TabIndex = 49;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.lbID.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbID.Location = new System.Drawing.Point(59, 32);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(17, 13);
            this.lbID.TabIndex = 51;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.lbName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(59, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 18);
            this.lbName.TabIndex = 50;
            this.lbName.Text = "Name - Surname";
            // 
            // buttons
            // 
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.buttons.Location = new System.Drawing.Point(0, 0);
            this.buttons.Name = "buttons";
            // 
            // buttons.Panel2
            // 
            this.buttons.Panel2.Controls.Add(this.btnPower);
            this.buttons.Panel2.Controls.Add(this.btnInfo);
            this.buttons.Panel2.Controls.Add(this.btnSettings);
            this.buttons.Size = new System.Drawing.Size(863, 53);
            this.buttons.SplitterDistance = 707;
            this.buttons.SplitterWidth = 1;
            this.buttons.TabIndex = 0;
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnPower.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.power;
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Location = new System.Drawing.Point(95, 6);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(40, 39);
            this.btnPower.TabIndex = 52;
            this.btnPower.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnInfo.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(9, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 39);
            this.btnInfo.TabIndex = 54;
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnSettings.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(53, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 39);
            this.btnSettings.TabIndex = 53;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.body.Location = new System.Drawing.Point(0, 0);
            this.body.Name = "body";
            // 
            // body.Panel1
            // 
            this.body.Panel1.Controls.Add(this.menu);
            // 
            // body.Panel2
            // 
            this.body.Panel2.Controls.Add(this.middle_events);
            this.body.Size = new System.Drawing.Size(1180, 515);
            this.body.SplitterDistance = 168;
            this.body.SplitterWidth = 1;
            this.body.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // menu.Panel1
            // 
            this.menu.Panel1.Controls.Add(this.btnContact);
            this.menu.Panel1.Controls.Add(this.btnRep);
            this.menu.Panel1.Controls.Add(this.btnFinAff);
            this.menu.Panel1.Controls.Add(this.btnReqDoc);
            this.menu.Panel1.Controls.Add(this.brnEx);
            this.menu.Panel1.Controls.Add(this.btnAddCrs);
            this.menu.Panel1.Controls.Add(this.btnSchedule);
            // 
            // menu.Panel2
            // 
            this.menu.Panel2.Controls.Add(this.rights);
            this.menu.Size = new System.Drawing.Size(168, 515);
            this.menu.SplitterDistance = 205;
            this.menu.SplitterWidth = 1;
            this.menu.TabIndex = 0;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Location = new System.Drawing.Point(-6, 174);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(175, 31);
            this.btnContact.TabIndex = 47;
            this.btnContact.Text = "Contact Us";
            this.btnContact.UseVisualStyleBackColor = false;
            // 
            // btnRep
            // 
            this.btnRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRep.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep.ForeColor = System.Drawing.Color.White;
            this.btnRep.Location = new System.Drawing.Point(-5, 144);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(175, 31);
            this.btnRep.TabIndex = 46;
            this.btnRep.Text = "Report an Issue";
            this.btnRep.UseVisualStyleBackColor = false;
            // 
            // btnFinAff
            // 
            this.btnFinAff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnFinAff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinAff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinAff.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinAff.ForeColor = System.Drawing.Color.White;
            this.btnFinAff.Location = new System.Drawing.Point(-5, 117);
            this.btnFinAff.Name = "btnFinAff";
            this.btnFinAff.Size = new System.Drawing.Size(175, 31);
            this.btnFinAff.TabIndex = 45;
            this.btnFinAff.Text = "Financial Affairs";
            this.btnFinAff.UseVisualStyleBackColor = false;
            // 
            // btnReqDoc
            // 
            this.btnReqDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnReqDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReqDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqDoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqDoc.ForeColor = System.Drawing.Color.White;
            this.btnReqDoc.Location = new System.Drawing.Point(-5, 87);
            this.btnReqDoc.Name = "btnReqDoc";
            this.btnReqDoc.Size = new System.Drawing.Size(175, 31);
            this.btnReqDoc.TabIndex = 44;
            this.btnReqDoc.Text = "Request Documents";
            this.btnReqDoc.UseVisualStyleBackColor = false;
            // 
            // brnEx
            // 
            this.brnEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.brnEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnEx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEx.ForeColor = System.Drawing.Color.White;
            this.brnEx.Location = new System.Drawing.Point(-6, 57);
            this.brnEx.Name = "brnEx";
            this.brnEx.Size = new System.Drawing.Size(175, 31);
            this.brnEx.TabIndex = 43;
            this.brnEx.Text = "Exam Schedule";
            this.brnEx.UseVisualStyleBackColor = false;
            // 
            // btnAddCrs
            // 
            this.btnAddCrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnAddCrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCrs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCrs.ForeColor = System.Drawing.Color.White;
            this.btnAddCrs.Location = new System.Drawing.Point(-6, 30);
            this.btnAddCrs.Name = "btnAddCrs";
            this.btnAddCrs.Size = new System.Drawing.Size(175, 31);
            this.btnAddCrs.TabIndex = 42;
            this.btnAddCrs.Text = "Add Courses";
            this.btnAddCrs.UseVisualStyleBackColor = false;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(-6, 0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(175, 31);
            this.btnSchedule.TabIndex = 41;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // rights
            // 
            this.rights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rights.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.rights.Location = new System.Drawing.Point(0, 0);
            this.rights.Name = "rights";
            this.rights.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rights.Panel1
            // 
            // 
            // rights.Panel2
            // 
            this.rights.Panel2.Controls.Add(this.label3);
            this.rights.Size = new System.Drawing.Size(168, 309);
            this.rights.SplitterDistance = 283;
            this.rights.SplitterWidth = 1;
            this.rights.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 8);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "All Rights Reserved";
            // 
            // middle_events
            // 
            this.middle_events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middle_events.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.middle_events.Location = new System.Drawing.Point(0, 0);
            this.middle_events.Name = "middle_events";
            // 
            // middle_events.Panel1
            // 
            this.middle_events.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // middle_events.Panel2
            // 
            this.middle_events.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.middle_events.Panel2.Controls.Add(this.lbNotification);
            this.middle_events.Panel2.Controls.Add(this.lable7);
            this.middle_events.Size = new System.Drawing.Size(1011, 515);
            this.middle_events.SplitterDistance = 854;
            this.middle_events.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(854, 515);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.table2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvCourses);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 218);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(135, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courses";
            // 
            // dgvCourses
            // 
            this.dgvCourses.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.ColumnHeadersVisible = false;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCourses});
            this.dgvCourses.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCourses.Location = new System.Drawing.Point(11, 43);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size = new System.Drawing.Size(327, 167);
            this.dgvCourses.TabIndex = 0;
            // 
            // clCourses
            // 
            this.clCourses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clCourses.HeaderText = "";
            this.clCourses.Name = "clCourses";
            this.clCourses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clCourses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.table2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(405, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 218);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCrs,
            this.chTime,
            this.chLocation});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 165);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chCrs
            // 
            this.chCrs.Text = "Course";
            this.chCrs.Width = 110;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 110;
            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            this.chLocation.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(131, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedule";
            // 
            // lbNotification
            // 
            this.lbNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.lbNotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNotification.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.SystemColors.Info;
            this.lbNotification.FormattingEnabled = true;
            this.lbNotification.ItemHeight = 15;
            this.lbNotification.Location = new System.Drawing.Point(12, 44);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(132, 450);
            this.lbNotification.TabIndex = 56;
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.lable7.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable7.Location = new System.Drawing.Point(31, 13);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(91, 18);
            this.lable7.TabIndex = 55;
            this.lable7.Text = "Notificatiions";
            // 
            // Student_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 572);
            this.Controls.Add(this.main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Portal";
            this.Text = "Student_Portal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_Portal_FormClosed);
            this.main.Panel1.ResumeLayout(false);
            this.main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.main.ResumeLayout(false);
            this.topMain.Panel1.ResumeLayout(false);
            this.topMain.Panel1.PerformLayout();
            this.topMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topMain)).EndInit();
            this.topMain.ResumeLayout(false);
            this.buttons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttons)).EndInit();
            this.buttons.ResumeLayout(false);
            this.body.Panel1.ResumeLayout(false);
            this.body.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            this.body.ResumeLayout(false);
            this.menu.Panel1.ResumeLayout(false);
            this.menu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.menu.ResumeLayout(false);
            this.rights.Panel2.ResumeLayout(false);
            this.rights.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rights)).EndInit();
            this.rights.ResumeLayout(false);
            this.middle_events.Panel1.ResumeLayout(false);
            this.middle_events.Panel2.ResumeLayout(false);
            this.middle_events.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.middle_events)).EndInit();
            this.middle_events.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer main;
        private System.Windows.Forms.SplitContainer topMain;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.SplitContainer buttons;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.SplitContainer body;
        private System.Windows.Forms.SplitContainer menu;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.Button btnFinAff;
        private System.Windows.Forms.Button btnReqDoc;
        private System.Windows.Forms.Button brnEx;
        private System.Windows.Forms.Button btnAddCrs;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.SplitContainer rights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer middle_events;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewLinkColumn clCourses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chCrs;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNotification;
        private System.Windows.Forms.Label lable7;
    }
}
namespace Student_Teacher_Form
{
    partial class Course_info_Stu
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCrsCd = new System.Windows.Forms.Label();
            this.gbTchrInfo = new System.Windows.Forms.GroupBox();
            this.lbDep = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTchrP = new System.Windows.Forms.PictureBox();
            this.lvMsg = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvAtch = new System.Windows.Forms.DataGridView();
            this.clTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAccCrsInStu = new System.Windows.Forms.Button();
            this.lbCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTchrInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTchrP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(19, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 41);
            this.label6.TabIndex = 23;
            this.label6.Text = "Course Info - ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbCrsCd
            // 
            this.lbCrsCd.AutoSize = true;
            this.lbCrsCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.lbCrsCd.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrsCd.ForeColor = System.Drawing.Color.Snow;
            this.lbCrsCd.Location = new System.Drawing.Point(211, 11);
            this.lbCrsCd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCrsCd.Name = "lbCrsCd";
            this.lbCrsCd.Size = new System.Drawing.Size(35, 41);
            this.lbCrsCd.TabIndex = 24;
            this.lbCrsCd.Text = "#";
            // 
            // gbTchrInfo
            // 
            this.gbTchrInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbTchrInfo.Controls.Add(this.lbCode);
            this.gbTchrInfo.Controls.Add(this.label4);
            this.gbTchrInfo.Controls.Add(this.lbDep);
            this.gbTchrInfo.Controls.Add(this.lbName);
            this.gbTchrInfo.Controls.Add(this.label3);
            this.gbTchrInfo.Controls.Add(this.label1);
            this.gbTchrInfo.Controls.Add(this.pbTchrP);
            this.gbTchrInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTchrInfo.Location = new System.Drawing.Point(60, 116);
            this.gbTchrInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbTchrInfo.Name = "gbTchrInfo";
            this.gbTchrInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbTchrInfo.Size = new System.Drawing.Size(949, 174);
            this.gbTchrInfo.TabIndex = 25;
            this.gbTchrInfo.TabStop = false;
            this.gbTchrInfo.Text = "Course Info";
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDep.Location = new System.Drawing.Point(304, 88);
            this.lbDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(42, 24);
            this.lbDep.TabIndex = 8;
            this.lbDep.Text = "null";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(304, 53);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 24);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // pbTchrP
            // 
            this.pbTchrP.Image = global::Student_Teacher_Form.Properties.Resources.anon;
            this.pbTchrP.Location = new System.Drawing.Point(39, 42);
            this.pbTchrP.Margin = new System.Windows.Forms.Padding(4);
            this.pbTchrP.Name = "pbTchrP";
            this.pbTchrP.Size = new System.Drawing.Size(99, 103);
            this.pbTchrP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTchrP.TabIndex = 0;
            this.pbTchrP.TabStop = false;
            // 
            // lvMsg
            // 
            this.lvMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chDate,
            this.chInst,
            this.chMessage});
            this.lvMsg.GridLines = true;
            this.lvMsg.Location = new System.Drawing.Point(21, 34);
            this.lvMsg.Margin = new System.Windows.Forms.Padding(4);
            this.lvMsg.Name = "lvMsg";
            this.lvMsg.Size = new System.Drawing.Size(908, 138);
            this.lvMsg.TabIndex = 26;
            this.lvMsg.UseCompatibleStateImageBehavior = false;
            this.lvMsg.View = System.Windows.Forms.View.Details;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 110;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 110;
            // 
            // chInst
            // 
            this.chInst.Text = "Instructor";
            this.chInst.Width = 110;
            // 
            // chMessage
            // 
            this.chMessage.Text = "Message";
            this.chMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMessage.Width = 348;
            // 
            // dgvAtch
            // 
            this.dgvAtch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAtch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTitle,
            this.clInstructor,
            this.clLink});
            this.dgvAtch.Location = new System.Drawing.Point(17, 34);
            this.dgvAtch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAtch.Name = "dgvAtch";
            this.dgvAtch.ReadOnly = true;
            this.dgvAtch.RowHeadersVisible = false;
            this.dgvAtch.Size = new System.Drawing.Size(909, 142);
            this.dgvAtch.TabIndex = 27;
            // 
            // clTitle
            // 
            this.clTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTitle.HeaderText = "Title";
            this.clTitle.Name = "clTitle";
            this.clTitle.ReadOnly = true;
            this.clTitle.Width = 75;
            // 
            // clInstructor
            // 
            this.clInstructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clInstructor.HeaderText = "Instructor";
            this.clInstructor.Name = "clInstructor";
            this.clInstructor.ReadOnly = true;
            this.clInstructor.Width = 118;
            // 
            // clLink
            // 
            this.clLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLink.HeaderText = "Download";
            this.clLink.Name = "clLink";
            this.clLink.ReadOnly = true;
            this.clLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvMsg);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(949, 193);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages and Announcements";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAtch);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 558);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(949, 192);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attachments";
            // 
            // btnAccCrsInStu
            // 
            this.btnAccCrsInStu.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccCrsInStu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccCrsInStu.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccCrsInStu.FlatAppearance.BorderSize = 0;
            this.btnAccCrsInStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCrsInStu.Location = new System.Drawing.Point(499, 762);
            this.btnAccCrsInStu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccCrsInStu.Name = "btnAccCrsInStu";
            this.btnAccCrsInStu.Size = new System.Drawing.Size(60, 54);
            this.btnAccCrsInStu.TabIndex = 31;
            this.btnAccCrsInStu.UseVisualStyleBackColor = true;
            this.btnAccCrsInStu.Click += new System.EventHandler(this.btnAccCrsInStu_Click);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(304, 124);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(42, 24);
            this.lbCode.TabIndex = 10;
            this.lbCode.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code:";
            // 
            // Course_info_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 828);
            this.Controls.Add(this.btnAccCrsInStu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTchrInfo);
            this.Controls.Add(this.lbCrsCd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Course_info_Stu";
            this.Text = "Course_info_Stu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Course_info_Stu_FormClosed);
            this.Load += new System.EventHandler(this.Course_info_Stu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTchrInfo.ResumeLayout(false);
            this.gbTchrInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTchrP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCrsCd;
        private System.Windows.Forms.GroupBox gbTchrInfo;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTchrP;
        private System.Windows.Forms.ListView lvMsg;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chInst;
        private System.Windows.Forms.ColumnHeader chMessage;
        private System.Windows.Forms.DataGridView dgvAtch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAccCrsInStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInstructor;
        private System.Windows.Forms.DataGridViewLinkColumn clLink;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label label4;
    }
}
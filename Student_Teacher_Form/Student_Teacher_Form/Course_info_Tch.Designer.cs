using System;

namespace Student_Teacher_Form
{
    partial class Course_info_Tch
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
            this.lbCrsCd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtPathD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSbmCM = new System.Windows.Forms.Button();
            this.txtTtCM = new System.Windows.Forms.TextBox();
            this.tbBdyCM = new System.Windows.Forms.TextBox();
            this.btnBrwsD = new System.Windows.Forms.Button();
            this.btnUpD = new System.Windows.Forms.Button();
            this.dtpEx = new System.Windows.Forms.DateTimePicker();
            this.btnSbmtEx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfoD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.btnAccCrsInTch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbChanges = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCrsCd
            // 
            this.lbCrsCd.AutoSize = true;
            this.lbCrsCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.lbCrsCd.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrsCd.ForeColor = System.Drawing.Color.Snow;
            this.lbCrsCd.Location = new System.Drawing.Point(158, 9);
            this.lbCrsCd.Name = "lbCrsCd";
            this.lbCrsCd.Size = new System.Drawing.Size(28, 33);
            this.lbCrsCd.TabIndex = 27;
            this.lbCrsCd.Text = "#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 33);
            this.label6.TabIndex = 26;
            this.label6.Text = "Course Info - ";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // txtPathD
            // 
            this.txtPathD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathD.Location = new System.Drawing.Point(11, 59);
            this.txtPathD.Name = "txtPathD";
            this.txtPathD.Size = new System.Drawing.Size(251, 26);
            this.txtPathD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Title:";
            // 
            // btnSbmCM
            // 
            this.btnSbmCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnSbmCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSbmCM.FlatAppearance.BorderSize = 0;
            this.btnSbmCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSbmCM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSbmCM.ForeColor = System.Drawing.Color.White;
            this.btnSbmCM.Location = new System.Drawing.Point(403, 210);
            this.btnSbmCM.Name = "btnSbmCM";
            this.btnSbmCM.Size = new System.Drawing.Size(103, 31);
            this.btnSbmCM.TabIndex = 33;
            this.btnSbmCM.Text = "Submit";
            this.btnSbmCM.UseVisualStyleBackColor = false;
            this.btnSbmCM.Click += new System.EventHandler(this.btnSbmCM_Click);
            // 
            // txtTtCM
            // 
            this.txtTtCM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtCM.Location = new System.Drawing.Point(64, 34);
            this.txtTtCM.Name = "txtTtCM";
            this.txtTtCM.Size = new System.Drawing.Size(441, 26);
            this.txtTtCM.TabIndex = 32;
            // 
            // tbBdyCM
            // 
            this.tbBdyCM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBdyCM.Location = new System.Drawing.Point(21, 67);
            this.tbBdyCM.Multiline = true;
            this.tbBdyCM.Name = "tbBdyCM";
            this.tbBdyCM.Size = new System.Drawing.Size(485, 138);
            this.tbBdyCM.TabIndex = 31;
            // 
            // btnBrwsD
            // 
            this.btnBrwsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnBrwsD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrwsD.FlatAppearance.BorderSize = 0;
            this.btnBrwsD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrwsD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrwsD.ForeColor = System.Drawing.Color.White;
            this.btnBrwsD.Location = new System.Drawing.Point(282, 56);
            this.btnBrwsD.Name = "btnBrwsD";
            this.btnBrwsD.Size = new System.Drawing.Size(103, 31);
            this.btnBrwsD.TabIndex = 36;
            this.btnBrwsD.Text = "Browse";
            this.btnBrwsD.UseVisualStyleBackColor = false;
            this.btnBrwsD.Click += new System.EventHandler(this.btnBrwsD_Click);
            // 
            // btnUpD
            // 
            this.btnUpD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnUpD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpD.FlatAppearance.BorderSize = 0;
            this.btnUpD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpD.ForeColor = System.Drawing.Color.White;
            this.btnUpD.Location = new System.Drawing.Point(391, 56);
            this.btnUpD.Name = "btnUpD";
            this.btnUpD.Size = new System.Drawing.Size(103, 31);
            this.btnUpD.TabIndex = 37;
            this.btnUpD.Text = "Upload";
            this.btnUpD.UseVisualStyleBackColor = false;
            this.btnUpD.Click += new System.EventHandler(this.btnUpD_Click);
            // 
            // dtpEx
            // 
            this.dtpEx.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEx.CustomFormat = "hh:mm dd-MM-yyyy";
            this.dtpEx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEx.Location = new System.Drawing.Point(12, 58);
            this.dtpEx.Name = "dtpEx";
            this.dtpEx.Size = new System.Drawing.Size(256, 26);
            this.dtpEx.TabIndex = 42;
            // 
            // btnSbmtEx
            // 
            this.btnSbmtEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnSbmtEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSbmtEx.FlatAppearance.BorderSize = 0;
            this.btnSbmtEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSbmtEx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSbmtEx.ForeColor = System.Drawing.Color.White;
            this.btnSbmtEx.Location = new System.Drawing.Point(280, 58);
            this.btnSbmtEx.Name = "btnSbmtEx";
            this.btnSbmtEx.Size = new System.Drawing.Size(103, 31);
            this.btnSbmtEx.TabIndex = 43;
            this.btnSbmtEx.Text = "Submit";
            this.btnSbmtEx.UseVisualStyleBackColor = false;
            this.btnSbmtEx.Click += new System.EventHandler(this.btnSbmtEx_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 126);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Documents";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInfoD);
            this.panel1.Controls.Add(this.btnUpD);
            this.panel1.Controls.Add(this.btnBrwsD);
            this.panel1.Controls.Add(this.txtPathD);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 101);
            this.panel1.TabIndex = 39;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Info:";
            // 
            // txtInfoD
            // 
            this.txtInfoD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoD.Location = new System.Drawing.Point(61, 9);
            this.txtInfoD.Name = "txtInfoD";
            this.txtInfoD.Size = new System.Drawing.Size(434, 26);
            this.txtInfoD.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSbmCM);
            this.groupBox2.Controls.Add(this.txtTtCM);
            this.groupBox2.Controls.Add(this.tbBdyCM);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 247);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write Message";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnSbmtEx);
            this.groupBox4.Controls.Add(this.txtPlace);
            this.groupBox4.Controls.Add(this.dtpEx);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(91, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 107);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Exam Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Location:";
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(80, 27);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(304, 26);
            this.txtPlace.TabIndex = 36;
            // 
            // btnAccCrsInTch
            // 
            this.btnAccCrsInTch.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccCrsInTch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccCrsInTch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccCrsInTch.FlatAppearance.BorderSize = 0;
            this.btnAccCrsInTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCrsInTch.Location = new System.Drawing.Point(286, 600);
            this.btnAccCrsInTch.Name = "btnAccCrsInTch";
            this.btnAccCrsInTch.Size = new System.Drawing.Size(45, 44);
            this.btnAccCrsInTch.TabIndex = 48;
            this.btnAccCrsInTch.UseVisualStyleBackColor = true;
            this.btnAccCrsInTch.Click += new System.EventHandler(this.btnAccCrsInTch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChanges.Location = new System.Drawing.Point(36, 617);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(25, 13);
            this.lbChanges.TabIndex = 36;
            this.lbChanges.Text = "null";
            this.lbChanges.Visible = false;
            // 
            // Course_info_Tch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 653);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.btnAccCrsInTch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCrsCd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Course_info_Tch";
            this.Text = "Course_info_Tch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Course_info_Tch_FormClosed);
            this.Enter += new System.EventHandler(this.Course_info_Tch_Enter);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCrsCd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtPathD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSbmCM;
        private System.Windows.Forms.TextBox txtTtCM;
        private System.Windows.Forms.TextBox tbBdyCM;
        private System.Windows.Forms.Button btnBrwsD;
        private System.Windows.Forms.Button btnUpD;
        private System.Windows.Forms.DateTimePicker dtpEx;
        private System.Windows.Forms.Button btnSbmtEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAccCrsInTch;
        private System.Windows.Forms.Label lbChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfoD;
        private System.Windows.Forms.Panel panel1;
    }
}
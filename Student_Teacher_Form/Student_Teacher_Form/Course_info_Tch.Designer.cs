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
            this.btnUpM = new System.Windows.Forms.Button();
            this.btnBrwsM = new System.Windows.Forms.Button();
            this.txtPathM = new System.Windows.Forms.TextBox();
            this.cbCrsEx = new System.Windows.Forms.ComboBox();
            this.dtpEx = new System.Windows.Forms.DateTimePicker();
            this.btnSbmtEx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAccCrsInTch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbChanges = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.txtPathD.Location = new System.Drawing.Point(20, 31);
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
            this.btnBrwsD.Location = new System.Drawing.Point(292, 28);
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
            this.btnUpD.Location = new System.Drawing.Point(401, 28);
            this.btnUpD.Name = "btnUpD";
            this.btnUpD.Size = new System.Drawing.Size(103, 31);
            this.btnUpD.TabIndex = 37;
            this.btnUpD.Text = "Upload";
            this.btnUpD.UseVisualStyleBackColor = false;
            this.btnUpD.Click += new System.EventHandler(this.btnUpD_Click);
            // 
            // btnUpM
            // 
            this.btnUpM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnUpM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpM.FlatAppearance.BorderSize = 0;
            this.btnUpM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpM.ForeColor = System.Drawing.Color.White;
            this.btnUpM.Location = new System.Drawing.Point(401, 24);
            this.btnUpM.Name = "btnUpM";
            this.btnUpM.Size = new System.Drawing.Size(103, 31);
            this.btnUpM.TabIndex = 40;
            this.btnUpM.Text = "Upload";
            this.btnUpM.UseVisualStyleBackColor = false;
            this.btnUpM.Click += new System.EventHandler(this.btnUpD_Click);
            // 
            // btnBrwsM
            // 
            this.btnBrwsM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnBrwsM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrwsM.FlatAppearance.BorderSize = 0;
            this.btnBrwsM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrwsM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrwsM.ForeColor = System.Drawing.Color.White;
            this.btnBrwsM.Location = new System.Drawing.Point(292, 24);
            this.btnBrwsM.Name = "btnBrwsM";
            this.btnBrwsM.Size = new System.Drawing.Size(103, 31);
            this.btnBrwsM.TabIndex = 39;
            this.btnBrwsM.Text = "Browse";
            this.btnBrwsM.UseVisualStyleBackColor = false;
            this.btnBrwsM.Click += new System.EventHandler(this.btnBrwsD_Click);
            // 
            // txtPathM
            // 
            this.txtPathM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathM.Location = new System.Drawing.Point(20, 27);
            this.txtPathM.Name = "txtPathM";
            this.txtPathM.Size = new System.Drawing.Size(251, 26);
            this.txtPathM.TabIndex = 38;
            // 
            // cbCrsEx
            // 
            this.cbCrsEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrsEx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrsEx.FormattingEnabled = true;
            this.cbCrsEx.Location = new System.Drawing.Point(12, 26);
            this.cbCrsEx.Name = "cbCrsEx";
            this.cbCrsEx.Size = new System.Drawing.Size(371, 26);
            this.cbCrsEx.TabIndex = 41;
            // 
            // dtpEx
            // 
            this.dtpEx.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEx.Location = new System.Drawing.Point(12, 58);
            this.dtpEx.Name = "dtpEx";
            this.dtpEx.Size = new System.Drawing.Size(259, 26);
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
            this.groupBox1.Controls.Add(this.btnUpD);
            this.groupBox1.Controls.Add(this.btnBrwsD);
            this.groupBox1.Controls.Add(this.txtPathD);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 78);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Documents";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpM);
            this.groupBox3.Controls.Add(this.btnBrwsM);
            this.groupBox3.Controls.Add(this.txtPathM);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 71);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upload Marks";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSbmtEx);
            this.groupBox4.Controls.Add(this.dtpEx);
            this.groupBox4.Controls.Add(this.cbCrsEx);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(90, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 107);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Exam Date";
            // 
            // btnAccCrsInTch
            // 
            this.btnAccCrsInTch.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccCrsInTch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccCrsInTch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccCrsInTch.FlatAppearance.BorderSize = 0;
            this.btnAccCrsInTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCrsInTch.Location = new System.Drawing.Point(285, 638);
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
            this.lbChanges.Location = new System.Drawing.Point(35, 656);
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
            this.ClientSize = new System.Drawing.Size(615, 688);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.btnAccCrsInTch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnUpM;
        private System.Windows.Forms.Button btnBrwsM;
        private System.Windows.Forms.TextBox txtPathM;
        private System.Windows.Forms.ComboBox cbCrsEx;
        private System.Windows.Forms.DateTimePicker dtpEx;
        private System.Windows.Forms.Button btnSbmtEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAccCrsInTch;
        private System.Windows.Forms.Label lbChanges;
    }
}
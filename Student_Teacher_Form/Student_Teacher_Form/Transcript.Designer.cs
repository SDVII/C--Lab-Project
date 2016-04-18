namespace Student_Teacher_Form
{
    partial class Transcript
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
            this.cbSemster = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lvGrades = new System.Windows.Forms.ListView();
            this.chCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSbmSem = new System.Windows.Forms.Button();
            this.btnAccTrn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Transcript";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cbSemster
            // 
            this.cbSemster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemster.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemster.FormattingEnabled = true;
            this.cbSemster.Location = new System.Drawing.Point(151, 31);
            this.cbSemster.Name = "cbSemster";
            this.cbSemster.Size = new System.Drawing.Size(121, 26);
            this.cbSemster.TabIndex = 22;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(24, 31);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 26);
            this.cbYear.TabIndex = 23;
            // 
            // lvGrades
            // 
            this.lvGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCourse,
            this.chInst,
            this.chGrade});
            this.lvGrades.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGrades.GridLines = true;
            this.lvGrades.Location = new System.Drawing.Point(24, 68);
            this.lvGrades.Name = "lvGrades";
            this.lvGrades.Size = new System.Drawing.Size(334, 175);
            this.lvGrades.TabIndex = 24;
            this.lvGrades.UseCompatibleStateImageBehavior = false;
            this.lvGrades.View = System.Windows.Forms.View.Details;
            // 
            // chCourse
            // 
            this.chCourse.Text = "Course";
            this.chCourse.Width = 110;
            // 
            // chInst
            // 
            this.chInst.Text = "Instructor";
            this.chInst.Width = 110;
            // 
            // chGrade
            // 
            this.chGrade.Text = "Grade";
            this.chGrade.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSbmSem);
            this.groupBox1.Controls.Add(this.lvGrades);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.cbSemster);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 262);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Semster Search";
            // 
            // btnSbmSem
            // 
            this.btnSbmSem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnSbmSem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSbmSem.FlatAppearance.BorderSize = 0;
            this.btnSbmSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSbmSem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSbmSem.ForeColor = System.Drawing.Color.White;
            this.btnSbmSem.Location = new System.Drawing.Point(278, 31);
            this.btnSbmSem.Name = "btnSbmSem";
            this.btnSbmSem.Size = new System.Drawing.Size(80, 28);
            this.btnSbmSem.TabIndex = 29;
            this.btnSbmSem.Text = "Submit";
            this.btnSbmSem.UseVisualStyleBackColor = false;
            this.btnSbmSem.Click += new System.EventHandler(this.btnSbmSem_Click);
            // 
            // btnAccTrn
            // 
            this.btnAccTrn.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccTrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccTrn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccTrn.FlatAppearance.BorderSize = 0;
            this.btnAccTrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccTrn.Location = new System.Drawing.Point(219, 348);
            this.btnAccTrn.Name = "btnAccTrn";
            this.btnAccTrn.Size = new System.Drawing.Size(45, 44);
            this.btnAccTrn.TabIndex = 30;
            this.btnAccTrn.UseVisualStyleBackColor = true;
            this.btnAccTrn.Click += new System.EventHandler(this.btnAccTrn_Click);
            // 
            // Transcript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.btnAccTrn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Transcript";
            this.Text = "Transcript";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Transcript_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSemster;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ListView lvGrades;
        private System.Windows.Forms.ColumnHeader chCourse;
        private System.Windows.Forms.ColumnHeader chInst;
        private System.Windows.Forms.ColumnHeader chGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSbmSem;
        private System.Windows.Forms.Button btnAccTrn;
    }
}
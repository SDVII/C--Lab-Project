namespace Student_Teacher_Form
{
    partial class Exam_Schedule
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
            this.lvExSchd = new System.Windows.Forms.ListView();
            this.chCrsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAccExSchd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Exam Schedule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lvExSchd
            // 
            this.lvExSchd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCrsID,
            this.chDate,
            this.chLoc});
            this.lvExSchd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvExSchd.GridLines = true;
            this.lvExSchd.Location = new System.Drawing.Point(18, 78);
            this.lvExSchd.Name = "lvExSchd";
            this.lvExSchd.Size = new System.Drawing.Size(669, 226);
            this.lvExSchd.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvExSchd.TabIndex = 22;
            this.lvExSchd.UseCompatibleStateImageBehavior = false;
            this.lvExSchd.View = System.Windows.Forms.View.Details;
            // 
            // chCrsID
            // 
            this.chCrsID.Text = "Course ID";
            this.chCrsID.Width = 110;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 110;
            // 
            // chLoc
            // 
            this.chLoc.Text = "Location";
            this.chLoc.Width = 445;
            // 
            // btnAccExSchd
            // 
            this.btnAccExSchd.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccExSchd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccExSchd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccExSchd.FlatAppearance.BorderSize = 0;
            this.btnAccExSchd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccExSchd.Location = new System.Drawing.Point(332, 319);
            this.btnAccExSchd.Name = "btnAccExSchd";
            this.btnAccExSchd.Size = new System.Drawing.Size(45, 44);
            this.btnAccExSchd.TabIndex = 30;
            this.btnAccExSchd.UseVisualStyleBackColor = true;
            this.btnAccExSchd.Click += new System.EventHandler(this.btnAccExSchd_Click);
            // 
            // Exam_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 377);
            this.Controls.Add(this.btnAccExSchd);
            this.Controls.Add(this.lvExSchd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Exam_Schedule";
            this.Text = "Exam_Schedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exam_Schedule_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvExSchd;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chCrsID;
        private System.Windows.Forms.ColumnHeader chLoc;
        private System.Windows.Forms.Button btnAccExSchd;
    }
}
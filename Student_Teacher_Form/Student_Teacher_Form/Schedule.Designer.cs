namespace Student_Teacher_Form
{
    partial class Schedule
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
            this.lvSchd = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAccSchd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(26, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 50);
            this.label6.TabIndex = 19;
            this.label6.Text = "Schedule";
            // 
            // lvSchd
            // 
            this.lvSchd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chMon,
            this.chTue,
            this.chWen,
            this.chThu,
            this.chFri,
            this.chSat,
            this.chSun});
            this.lvSchd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchd.GridLines = true;
            this.lvSchd.Location = new System.Drawing.Point(54, 138);
            this.lvSchd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvSchd.Name = "lvSchd";
            this.lvSchd.Size = new System.Drawing.Size(1328, 556);
            this.lvSchd.TabIndex = 20;
            this.lvSchd.UseCompatibleStateImageBehavior = false;
            this.lvSchd.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 110;
            // 
            // chMon
            // 
            this.chMon.Text = "Monday";
            this.chMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMon.Width = 110;
            // 
            // chTue
            // 
            this.chTue.Text = "Tuesday";
            this.chTue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTue.Width = 110;
            // 
            // chWen
            // 
            this.chWen.Text = "Wednesday";
            this.chWen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWen.Width = 110;
            // 
            // chThu
            // 
            this.chThu.Text = "Thursday";
            this.chThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chThu.Width = 110;
            // 
            // chFri
            // 
            this.chFri.Text = "Friday";
            this.chFri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFri.Width = 110;
            // 
            // chSat
            // 
            this.chSat.Text = "Saturday";
            this.chSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSat.Width = 110;
            // 
            // chSun
            // 
            this.chSun.Text = "Sunday";
            this.chSun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSun.Width = 110;
            // 
            // btnAccSchd
            // 
            this.btnAccSchd.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccSchd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccSchd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccSchd.FlatAppearance.BorderSize = 0;
            this.btnAccSchd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSchd.Location = new System.Drawing.Point(684, 716);
            this.btnAccSchd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccSchd.Name = "btnAccSchd";
            this.btnAccSchd.Size = new System.Drawing.Size(68, 68);
            this.btnAccSchd.TabIndex = 29;
            this.btnAccSchd.UseVisualStyleBackColor = true;
            this.btnAccSchd.Click += new System.EventHandler(this.btnAccSchd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1437, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 809);
            this.Controls.Add(this.btnAccSchd);
            this.Controls.Add(this.lvSchd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Schedule_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvSchd;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chMon;
        private System.Windows.Forms.ColumnHeader chTue;
        private System.Windows.Forms.ColumnHeader chWen;
        private System.Windows.Forms.ColumnHeader chThu;
        private System.Windows.Forms.ColumnHeader chFri;
        private System.Windows.Forms.ColumnHeader chSat;
        private System.Windows.Forms.ColumnHeader chSun;
        private System.Windows.Forms.Button btnAccSchd;
    }
}
namespace Student_Teacher_Form
{
    partial class Report_Issue
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
            this.tbBdyR = new System.Windows.Forms.TextBox();
            this.txtTtlR = new System.Windows.Forms.TextBox();
            this.btnSbmR = new System.Windows.Forms.Button();
            this.cbCtgR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAccR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbChanges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBdyR
            // 
            this.tbBdyR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBdyR.Location = new System.Drawing.Point(130, 242);
            this.tbBdyR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbBdyR.Multiline = true;
            this.tbBdyR.Name = "tbBdyR";
            this.tbBdyR.Size = new System.Drawing.Size(698, 262);
            this.tbBdyR.TabIndex = 0;
            // 
            // txtTtlR
            // 
            this.txtTtlR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtlR.Location = new System.Drawing.Point(216, 179);
            this.txtTtlR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTtlR.Name = "txtTtlR";
            this.txtTtlR.Size = new System.Drawing.Size(610, 44);
            this.txtTtlR.TabIndex = 1;
            // 
            // btnSbmR
            // 
            this.btnSbmR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.btnSbmR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSbmR.FlatAppearance.BorderSize = 0;
            this.btnSbmR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSbmR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSbmR.ForeColor = System.Drawing.Color.White;
            this.btnSbmR.Location = new System.Drawing.Point(624, 519);
            this.btnSbmR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSbmR.Name = "btnSbmR";
            this.btnSbmR.Size = new System.Drawing.Size(206, 60);
            this.btnSbmR.TabIndex = 6;
            this.btnSbmR.Text = "Submit";
            this.btnSbmR.UseVisualStyleBackColor = false;
            this.btnSbmR.Click += new System.EventHandler(this.btnSbmR_Click);
            // 
            // cbCtgR
            // 
            this.cbCtgR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCtgR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCtgR.FormattingEnabled = true;
            this.cbCtgR.Items.AddRange(new object[] {
            "Report Bug",
            "Connection Problems",
            "Inaccurate Messages",
            "Sugestions"});
            this.cbCtgR.Location = new System.Drawing.Point(130, 523);
            this.cbCtgR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCtgR.Name = "cbCtgR";
            this.cbCtgR.Size = new System.Drawing.Size(454, 45);
            this.cbCtgR.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(26, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 66);
            this.label6.TabIndex = 15;
            this.label6.Text = "Report an Issue";
            // 
            // btnAccR
            // 
            this.btnAccR.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccR.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccR.FlatAppearance.BorderSize = 0;
            this.btnAccR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccR.Location = new System.Drawing.Point(452, 604);
            this.btnAccR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccR.Name = "btnAccR";
            this.btnAccR.Size = new System.Drawing.Size(90, 85);
            this.btnAccR.TabIndex = 25;
            this.btnAccR.UseVisualStyleBackColor = true;
            this.btnAccR.Click += new System.EventHandler(this.btnAccR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.Untitled_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChanges.Location = new System.Drawing.Point(32, 637);
            this.lbChanges.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(44, 27);
            this.lbChanges.TabIndex = 37;
            this.lbChanges.Text = "null";
            this.lbChanges.Visible = false;
            // 
            // Report_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.btnAccR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCtgR);
            this.Controls.Add(this.btnSbmR);
            this.Controls.Add(this.txtTtlR);
            this.Controls.Add(this.tbBdyR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Report_Issue";
            this.Text = "Report_Issue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Report_Issue_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBdyR;
        private System.Windows.Forms.TextBox txtTtlR;
        private System.Windows.Forms.Button btnSbmR;
        private System.Windows.Forms.ComboBox cbCtgR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAccR;
        private System.Windows.Forms.Label lbChanges;
    }
}
namespace Student_Teacher_Form
{
    partial class Course_Add
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
            this.lbAvlC = new System.Windows.Forms.ListBox();
            this.lbCurC = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSections = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbChanges = new System.Windows.Forms.Label();
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnRmvC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAvlC
            // 
            this.lbAvlC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvlC.FormattingEnabled = true;
            this.lbAvlC.ItemHeight = 18;
            this.lbAvlC.Location = new System.Drawing.Point(14, 29);
            this.lbAvlC.Name = "lbAvlC";
            this.lbAvlC.Size = new System.Drawing.Size(203, 130);
            this.lbAvlC.TabIndex = 2;
            // 
            // lbCurC
            // 
            this.lbCurC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurC.FormattingEnabled = true;
            this.lbCurC.ItemHeight = 18;
            this.lbCurC.Location = new System.Drawing.Point(18, 26);
            this.lbCurC.Name = "lbCurC";
            this.lbCurC.Size = new System.Drawing.Size(196, 166);
            this.lbCurC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Course Registration";
            // 
            // cbSections
            // 
            this.cbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSections.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSections.FormattingEnabled = true;
            this.cbSections.Location = new System.Drawing.Point(14, 173);
            this.cbSections.Name = "cbSections";
            this.cbSections.Size = new System.Drawing.Size(203, 26);
            this.cbSections.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSections);
            this.groupBox1.Controls.Add(this.lbAvlC);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 218);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Courses:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCurC);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(350, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 218);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Courses";
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChanges.Location = new System.Drawing.Point(33, 329);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(25, 13);
            this.lbChanges.TabIndex = 26;
            this.lbChanges.Text = "null";
            this.lbChanges.Visible = false;
            // 
            // btnAddC
            // 
            this.btnAddC.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_keyboard_arrow_right_black_24dp_2x1;
            this.btnAddC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAddC.FlatAppearance.BorderSize = 0;
            this.btnAddC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddC.Location = new System.Drawing.Point(287, 126);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(45, 44);
            this.btnAddC.TabIndex = 13;
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnRmvC
            // 
            this.btnRmvC.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_keyboard_arrow_left_black_24dp_2x1;
            this.btnRmvC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRmvC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnRmvC.FlatAppearance.BorderSize = 0;
            this.btnRmvC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvC.Location = new System.Drawing.Point(287, 176);
            this.btnRmvC.Name = "btnRmvC";
            this.btnRmvC.Size = new System.Drawing.Size(45, 44);
            this.btnRmvC.TabIndex = 12;
            this.btnRmvC.UseVisualStyleBackColor = true;
            this.btnRmvC.Click += new System.EventHandler(this.btnRmvC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.Untitled_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAccC
            // 
            this.btnAccC.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccC.FlatAppearance.BorderSize = 0;
            this.btnAccC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccC.Location = new System.Drawing.Point(287, 226);
            this.btnAccC.Name = "btnAccC";
            this.btnAccC.Size = new System.Drawing.Size(45, 44);
            this.btnAccC.TabIndex = 4;
            this.btnAccC.UseVisualStyleBackColor = true;
            this.btnAccC.Click += new System.EventHandler(this.btnAccC_Click);
            // 
            // Course_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 354);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.btnRmvC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAccC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Course_Add";
            this.Text = "laberl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Course_Add_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbAvlC;
        private System.Windows.Forms.ListBox lbCurC;
        private System.Windows.Forms.Button btnAccC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRmvC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.ComboBox cbSections;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbChanges;
    }
}
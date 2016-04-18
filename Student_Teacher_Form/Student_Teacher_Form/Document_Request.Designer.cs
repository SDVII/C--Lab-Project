namespace Student_Teacher_Form
{
    partial class Document_Request
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEng = new System.Windows.Forms.CheckBox();
            this.cbTr = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDocS = new System.Windows.Forms.ComboBox();
            this.btnAddD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDocL = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbRdyD = new System.Windows.Forms.ListBox();
            this.lbChanges = new System.Windows.Forms.Label();
            this.btnAccD = new System.Windows.Forms.Button();
            this.btnClrD = new System.Windows.Forms.Button();
            this.btnRmvD = new System.Windows.Forms.Button();
            this.btnSbmD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 66);
            this.label1.TabIndex = 9;
            this.label1.Text = "Online Document Request";
            // 
            // cbDoc
            // 
            this.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoc.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoc.FormattingEnabled = true;
            this.cbDoc.Items.AddRange(new object[] {
            "Student Certificate",
            "Transcript",
            "Official Transcript (in closed envelope)",
            "Referral-Suspension Cancellation Form",
            "Certificate of Language Proficiency",
            "Prep Transcript",
            "Prep Grade Document",
            "Disciplinary Record"});
            this.cbDoc.Location = new System.Drawing.Point(32, 106);
            this.cbDoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(428, 44);
            this.cbDoc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Document Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Language:";
            // 
            // cbEng
            // 
            this.cbEng.AutoSize = true;
            this.cbEng.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEng.Location = new System.Drawing.Point(34, 363);
            this.cbEng.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbEng.Name = "cbEng";
            this.cbEng.Size = new System.Drawing.Size(102, 41);
            this.cbEng.TabIndex = 13;
            this.cbEng.Text = "ENG";
            this.cbEng.UseVisualStyleBackColor = true;
            // 
            // cbTr
            // 
            this.cbTr.AutoSize = true;
            this.cbTr.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTr.Location = new System.Drawing.Point(176, 363);
            this.cbTr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTr.Name = "cbTr";
            this.cbTr.Size = new System.Drawing.Size(80, 41);
            this.cbTr.TabIndex = 14;
            this.cbTr.Text = "TR";
            this.cbTr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDocS);
            this.groupBox1.Controls.Add(this.cbTr);
            this.groupBox1.Controls.Add(this.cbEng);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddD);
            this.groupBox1.Controls.Add(this.cbDoc);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(504, 444);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Document";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Shipping Options:";
            // 
            // cbDocS
            // 
            this.cbDocS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocS.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocS.FormattingEnabled = true;
            this.cbDocS.Items.AddRange(new object[] {
            "Sisli Campus",
            "Calata Campus",
            "Hand-Delivery",
            "Post",
            "Email"});
            this.cbDocS.Location = new System.Drawing.Point(38, 238);
            this.cbDocS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbDocS.Name = "cbDocS";
            this.cbDocS.Size = new System.Drawing.Size(428, 44);
            this.cbDocS.TabIndex = 16;
            // 
            // btnAddD
            // 
            this.btnAddD.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_note_add_black_24dp_2x;
            this.btnAddD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAddD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddD.Location = new System.Drawing.Point(386, 346);
            this.btnAddD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddD.Name = "btnAddD";
            this.btnAddD.Size = new System.Drawing.Size(78, 73);
            this.btnAddD.TabIndex = 15;
            this.btnAddD.UseVisualStyleBackColor = true;
            this.btnAddD.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDocL);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(656, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(504, 444);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Document List";
            // 
            // lbDocL
            // 
            this.lbDocL.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocL.FormattingEnabled = true;
            this.lbDocL.ItemHeight = 37;
            this.lbDocL.Location = new System.Drawing.Point(34, 54);
            this.lbDocL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbDocL.Name = "lbDocL";
            this.lbDocL.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDocL.Size = new System.Drawing.Size(434, 300);
            this.lbDocL.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRdyD);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 706);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1112, 242);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ready Documents";
            // 
            // lbRdyD
            // 
            this.lbRdyD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbRdyD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRdyD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRdyD.FormattingEnabled = true;
            this.lbRdyD.ItemHeight = 37;
            this.lbRdyD.Location = new System.Drawing.Point(26, 54);
            this.lbRdyD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbRdyD.Name = "lbRdyD";
            this.lbRdyD.Size = new System.Drawing.Size(1052, 111);
            this.lbRdyD.TabIndex = 0;
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChanges.Location = new System.Drawing.Point(42, 994);
            this.lbChanges.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(44, 27);
            this.lbChanges.TabIndex = 26;
            this.lbChanges.Text = "null";
            this.lbChanges.Visible = false;
            // 
            // btnAccD
            // 
            this.btnAccD.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccD.FlatAppearance.BorderSize = 0;
            this.btnAccD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccD.Location = new System.Drawing.Point(572, 967);
            this.btnAccD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccD.Name = "btnAccD";
            this.btnAccD.Size = new System.Drawing.Size(78, 75);
            this.btnAccD.TabIndex = 22;
            this.btnAccD.UseVisualStyleBackColor = true;
            this.btnAccD.Click += new System.EventHandler(this.btnAccD_Click);
            // 
            // btnClrD
            // 
            this.btnClrD.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_remove_circle_outline_black_24dp_2x2;
            this.btnClrD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClrD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnClrD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClrD.Location = new System.Drawing.Point(938, 550);
            this.btnClrD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClrD.Name = "btnClrD";
            this.btnClrD.Size = new System.Drawing.Size(78, 73);
            this.btnClrD.TabIndex = 20;
            this.btnClrD.UseVisualStyleBackColor = true;
            this.btnClrD.Click += new System.EventHandler(this.btnClrD_Click);
            // 
            // btnRmvD
            // 
            this.btnRmvD.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_remove_circle_outline_black_24dp_2x;
            this.btnRmvD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRmvD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnRmvD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvD.Location = new System.Drawing.Point(1028, 550);
            this.btnRmvD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRmvD.Name = "btnRmvD";
            this.btnRmvD.Size = new System.Drawing.Size(78, 73);
            this.btnRmvD.TabIndex = 19;
            this.btnRmvD.UseVisualStyleBackColor = true;
            this.btnRmvD.Click += new System.EventHandler(this.btnRmvD_Click);
            // 
            // btnSbmD
            // 
            this.btnSbmD.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_add_circle_outline_black_24dp_2x;
            this.btnSbmD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSbmD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnSbmD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSbmD.Location = new System.Drawing.Point(1118, 548);
            this.btnSbmD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSbmD.Name = "btnSbmD";
            this.btnSbmD.Size = new System.Drawing.Size(78, 73);
            this.btnSbmD.TabIndex = 18;
            this.btnSbmD.UseVisualStyleBackColor = true;
            this.btnSbmD.Click += new System.EventHandler(this.btnSbmD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.Untitled_3;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1218, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Document_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 1065);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.btnAccD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClrD);
            this.Controls.Add(this.btnRmvD);
            this.Controls.Add(this.btnSbmD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Document_Request";
            this.Text = "Document_Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Document_Request_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEng;
        private System.Windows.Forms.CheckBox cbTr;
        private System.Windows.Forms.Button btnAddD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDocS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDocL;
        private System.Windows.Forms.Button btnSbmD;
        private System.Windows.Forms.Button btnRmvD;
        private System.Windows.Forms.Button btnClrD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbRdyD;
        private System.Windows.Forms.Button btnAccD;
        private System.Windows.Forms.Label lbChanges;
    }
}
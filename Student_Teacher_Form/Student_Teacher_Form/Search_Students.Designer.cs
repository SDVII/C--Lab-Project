namespace Student_Teacher_Form
{
    partial class Search_Students
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCrsTkn = new System.Windows.Forms.ListBox();
            this.lbGpa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSpr = new System.Windows.Forms.Label();
            this.lbDep = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbStuP = new System.Windows.Forms.PictureBox();
            this.txtSrchK = new System.Windows.Forms.TextBox();
            this.cbSrchTyp = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSrchS = new System.Windows.Forms.Button();
            this.btnAccSS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbChanges = new System.Windows.Forms.Label();
            this.lvSrchRes = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSuper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGPA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSrchRes = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSrchRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(96)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(24, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 41);
            this.label6.TabIndex = 19;
            this.label6.Text = "Student Search";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lbCrsTkn);
            this.groupBox1.Controls.Add(this.lbGpa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbSpr);
            this.groupBox1.Controls.Add(this.lbDep);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbStuP);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 490);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(744, 360);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // lbCrsTkn
            // 
            this.lbCrsTkn.BackColor = System.Drawing.SystemColors.Menu;
            this.lbCrsTkn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCrsTkn.FormattingEnabled = true;
            this.lbCrsTkn.ItemHeight = 23;
            this.lbCrsTkn.Location = new System.Drawing.Point(427, 253);
            this.lbCrsTkn.Margin = new System.Windows.Forms.Padding(4);
            this.lbCrsTkn.Name = "lbCrsTkn";
            this.lbCrsTkn.Size = new System.Drawing.Size(293, 69);
            this.lbCrsTkn.TabIndex = 14;
            // 
            // lbGpa
            // 
            this.lbGpa.AutoSize = true;
            this.lbGpa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGpa.Location = new System.Drawing.Point(429, 212);
            this.lbGpa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGpa.Name = "lbGpa";
            this.lbGpa.Size = new System.Drawing.Size(42, 24);
            this.lbGpa.TabIndex = 13;
            this.lbGpa.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Couses Taken:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "GPA:";
            // 
            // lbSpr
            // 
            this.lbSpr.AutoSize = true;
            this.lbSpr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpr.Location = new System.Drawing.Point(429, 168);
            this.lbSpr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpr.Name = "lbSpr";
            this.lbSpr.Size = new System.Drawing.Size(42, 24);
            this.lbSpr.TabIndex = 10;
            this.lbSpr.Text = "null";
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDep.Location = new System.Drawing.Point(429, 122);
            this.lbDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(42, 24);
            this.lbDep.TabIndex = 9;
            this.lbDep.Text = "null";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(429, 85);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(42, 24);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "null";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(429, 45);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 24);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Supervisor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // pbStuP
            // 
            this.pbStuP.Image = global::Student_Teacher_Form.Properties.Resources.anon;
            this.pbStuP.Location = new System.Drawing.Point(39, 48);
            this.pbStuP.Margin = new System.Windows.Forms.Padding(4);
            this.pbStuP.Name = "pbStuP";
            this.pbStuP.Size = new System.Drawing.Size(216, 223);
            this.pbStuP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStuP.TabIndex = 0;
            this.pbStuP.TabStop = false;
            // 
            // txtSrchK
            // 
            this.txtSrchK.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchK.Location = new System.Drawing.Point(36, 48);
            this.txtSrchK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSrchK.Name = "txtSrchK";
            this.txtSrchK.Size = new System.Drawing.Size(435, 30);
            this.txtSrchK.TabIndex = 21;
            // 
            // cbSrchTyp
            // 
            this.cbSrchTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSrchTyp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSrchTyp.FormattingEnabled = true;
            this.cbSrchTyp.Items.AddRange(new object[] {
            "Name",
            "ID",
            "Department"});
            this.cbSrchTyp.Location = new System.Drawing.Point(488, 48);
            this.cbSrchTyp.Margin = new System.Windows.Forms.Padding(4);
            this.cbSrchTyp.Name = "cbSrchTyp";
            this.cbSrchTyp.Size = new System.Drawing.Size(160, 31);
            this.cbSrchTyp.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSrchS);
            this.groupBox2.Controls.Add(this.cbSrchTyp);
            this.groupBox2.Controls.Add(this.txtSrchK);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(743, 120);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSrchS
            // 
            this.btnSrchS.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_search_black_24dp_2x;
            this.btnSrchS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSrchS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnSrchS.FlatAppearance.BorderSize = 0;
            this.btnSrchS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrchS.Location = new System.Drawing.Point(669, 40);
            this.btnSrchS.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrchS.Name = "btnSrchS";
            this.btnSrchS.Size = new System.Drawing.Size(52, 47);
            this.btnSrchS.TabIndex = 23;
            this.btnSrchS.UseVisualStyleBackColor = true;
            this.btnSrchS.Click += new System.EventHandler(this.btnSrchS_Click);
            // 
            // btnAccSS
            // 
            this.btnAccSS.BackgroundImage = global::Student_Teacher_Form.Properties.Resources.ic_check_black_24dp_2x1;
            this.btnAccSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccSS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnAccSS.FlatAppearance.BorderSize = 0;
            this.btnAccSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSS.Location = new System.Drawing.Point(380, 858);
            this.btnAccSS.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccSS.Name = "btnAccSS";
            this.btnAccSS.Size = new System.Drawing.Size(60, 54);
            this.btnAccSS.TabIndex = 29;
            this.btnAccSS.UseVisualStyleBackColor = true;
            this.btnAccSS.Click += new System.EventHandler(this.btnAccSS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Teacher_Form.Properties.Resources.Untitled_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChanges.Location = new System.Drawing.Point(28, 879);
            this.lbChanges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(28, 17);
            this.lbChanges.TabIndex = 27;
            this.lbChanges.Text = "null";
            this.lbChanges.Visible = false;
            // 
            // lvSrchRes
            // 
            this.lvSrchRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chID,
            this.chDepart,
            this.chSuper,
            this.chGPA});
            this.lvSrchRes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSrchRes.FullRowSelect = true;
            this.lvSrchRes.GridLines = true;
            this.lvSrchRes.Location = new System.Drawing.Point(40, 40);
            this.lvSrchRes.Margin = new System.Windows.Forms.Padding(4);
            this.lvSrchRes.MultiSelect = false;
            this.lvSrchRes.Name = "lvSrchRes";
            this.lvSrchRes.Size = new System.Drawing.Size(660, 161);
            this.lvSrchRes.TabIndex = 30;
            this.lvSrchRes.UseCompatibleStateImageBehavior = false;
            this.lvSrchRes.View = System.Windows.Forms.View.Details;
            this.lvSrchRes.SelectedIndexChanged += new System.EventHandler(this.lvSrchRes_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 100;
            // 
            // chDepart
            // 
            this.chDepart.Text = "Department";
            this.chDepart.Width = 213;
            // 
            // chSuper
            // 
            this.chSuper.Text = "Supervisor";
            this.chSuper.Width = 184;
            // 
            // chGPA
            // 
            this.chGPA.Text = "GPA";
            this.chGPA.Width = 92;
            // 
            // gbSrchRes
            // 
            this.gbSrchRes.Controls.Add(this.lvSrchRes);
            this.gbSrchRes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSrchRes.Location = new System.Drawing.Point(29, 235);
            this.gbSrchRes.Margin = new System.Windows.Forms.Padding(4);
            this.gbSrchRes.Name = "gbSrchRes";
            this.gbSrchRes.Padding = new System.Windows.Forms.Padding(4);
            this.gbSrchRes.Size = new System.Drawing.Size(745, 234);
            this.gbSrchRes.TabIndex = 31;
            this.gbSrchRes.TabStop = false;
            this.gbSrchRes.Text = "Search Results";
            // 
            // Search_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 798);
            this.Controls.Add(this.gbSrchRes);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.btnAccSS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search_Students";
            this.Text = "Search_Students";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_Students_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSrchRes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSpr;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSrchK;
        private System.Windows.Forms.ComboBox cbSrchTyp;
        private System.Windows.Forms.Button btnSrchS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGpa;
        private System.Windows.Forms.Button btnAccSS;
        private System.Windows.Forms.PictureBox pbStuP;
        private System.Windows.Forms.Label lbChanges;
        private System.Windows.Forms.ListBox lbCrsTkn;
        private System.Windows.Forms.ListView lvSrchRes;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDepart;
        private System.Windows.Forms.ColumnHeader chSuper;
        private System.Windows.Forms.ColumnHeader chGPA;
        private System.Windows.Forms.GroupBox gbSrchRes;
    }
}
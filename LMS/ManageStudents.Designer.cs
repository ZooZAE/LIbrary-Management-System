namespace LMS
{
    partial class ManageStudents
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.btSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddStudents = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.btDeleteStudent = new System.Windows.Forms.Button();
            this.cbGetStudent = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.cbGenderEdit = new System.Windows.Forms.ComboBox();
            this.tbPhoneEdit = new System.Windows.Forms.TextBox();
            this.tbEmailEdit = new System.Windows.Forms.TextBox();
            this.tbNameEdit = new System.Windows.Forms.TextBox();
            this.tbUIDEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpAddStudents.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tpAddStudents);
            this.tabControl1.Controls.Add(this.tpEdit);
            this.tabControl1.Location = new System.Drawing.Point(13, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 719);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a1;
            this.tpSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSearch.Controls.Add(this.btSearch);
            this.tpSearch.Controls.Add(this.dataGridView1);
            this.tpSearch.Controls.Add(this.tbSearch);
            this.tpSearch.Controls.Add(this.label1);
            this.tpSearch.Location = new System.Drawing.Point(4, 25);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(1384, 690);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "Search Students";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Yellow;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSearch.ForeColor = System.Drawing.Color.Green;
            this.btSearch.Location = new System.Drawing.Point(1195, 50);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(135, 43);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search UID";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 534);
            this.dataGridView1.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(289, 54);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(860, 30);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(133, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter UID";
            // 
            // tpAddStudents
            // 
            this.tpAddStudents.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a1;
            this.tpAddStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpAddStudents.Controls.Add(this.label17);
            this.tpAddStudents.Controls.Add(this.tbPhone);
            this.tpAddStudents.Controls.Add(this.tbEmail);
            this.tpAddStudents.Controls.Add(this.tbName);
            this.tpAddStudents.Controls.Add(this.tbUID);
            this.tpAddStudents.Controls.Add(this.label13);
            this.tpAddStudents.Controls.Add(this.label14);
            this.tpAddStudents.Controls.Add(this.label15);
            this.tpAddStudents.Controls.Add(this.label16);
            this.tpAddStudents.Controls.Add(this.btAddStudent);
            this.tpAddStudents.Controls.Add(this.cbGender);
            this.tpAddStudents.Location = new System.Drawing.Point(4, 25);
            this.tpAddStudents.Name = "tpAddStudents";
            this.tpAddStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddStudents.Size = new System.Drawing.Size(1384, 690);
            this.tpAddStudents.TabIndex = 1;
            this.tpAddStudents.Text = "Add Student";
            this.tpAddStudents.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(58, 548);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "Gender";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(165, 429);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(306, 28);
            this.tbPhone.TabIndex = 27;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(165, 321);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(306, 28);
            this.tbEmail.TabIndex = 26;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(165, 213);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(306, 28);
            this.tbName.TabIndex = 25;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // tbUID
            // 
            this.tbUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUID.Location = new System.Drawing.Point(165, 114);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(306, 28);
            this.tbUID.TabIndex = 24;
            this.tbUID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(58, 432);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(58, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(55, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(58, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "UID";
            // 
            // btAddStudent
            // 
            this.btAddStudent.BackColor = System.Drawing.Color.Yellow;
            this.btAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddStudent.ForeColor = System.Drawing.Color.DarkGreen;
            this.btAddStudent.Location = new System.Drawing.Point(869, 302);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(313, 76);
            this.btAddStudent.TabIndex = 10;
            this.btAddStudent.Text = "Add Student";
            this.btAddStudent.UseVisualStyleBackColor = false;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(167, 548);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(306, 30);
            this.cbGender.TabIndex = 9;
            // 
            // tpEdit
            // 
            this.tpEdit.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a1;
            this.tpEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEdit.Controls.Add(this.btDeleteStudent);
            this.tpEdit.Controls.Add(this.cbGetStudent);
            this.tpEdit.Controls.Add(this.label12);
            this.tpEdit.Controls.Add(this.btUpdate);
            this.tpEdit.Controls.Add(this.cbGenderEdit);
            this.tpEdit.Controls.Add(this.tbPhoneEdit);
            this.tpEdit.Controls.Add(this.tbEmailEdit);
            this.tpEdit.Controls.Add(this.tbNameEdit);
            this.tpEdit.Controls.Add(this.tbUIDEdit);
            this.tpEdit.Controls.Add(this.label7);
            this.tpEdit.Controls.Add(this.label8);
            this.tpEdit.Controls.Add(this.label9);
            this.tpEdit.Controls.Add(this.label10);
            this.tpEdit.Controls.Add(this.label11);
            this.tpEdit.Location = new System.Drawing.Point(4, 25);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(1384, 690);
            this.tpEdit.TabIndex = 2;
            this.tpEdit.Text = "Edit Student";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // btDeleteStudent
            // 
            this.btDeleteStudent.BackColor = System.Drawing.Color.Yellow;
            this.btDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteStudent.ForeColor = System.Drawing.Color.ForestGreen;
            this.btDeleteStudent.Location = new System.Drawing.Point(933, 335);
            this.btDeleteStudent.Name = "btDeleteStudent";
            this.btDeleteStudent.Size = new System.Drawing.Size(313, 76);
            this.btDeleteStudent.TabIndex = 26;
            this.btDeleteStudent.Text = "Delete Student";
            this.btDeleteStudent.UseVisualStyleBackColor = false;
            this.btDeleteStudent.Click += new System.EventHandler(this.btDeleteStudent_Click);
            // 
            // cbGetStudent
            // 
            this.cbGetStudent.DisplayMember = "ID";
            this.cbGetStudent.FormattingEnabled = true;
            this.cbGetStudent.Location = new System.Drawing.Point(891, 33);
            this.cbGetStudent.Name = "cbGetStudent";
            this.cbGetStudent.Size = new System.Drawing.Size(399, 24);
            this.cbGetStudent.TabIndex = 25;
            this.cbGetStudent.ValueMember = "ID";
            this.cbGetStudent.SelectedIndexChanged += new System.EventHandler(this.cbGetStudent_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(703, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Select Student";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btUpdate.Location = new System.Drawing.Point(933, 205);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(313, 76);
            this.btUpdate.TabIndex = 21;
            this.btUpdate.Text = "Update Student";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cbGenderEdit
            // 
            this.cbGenderEdit.FormattingEnabled = true;
            this.cbGenderEdit.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGenderEdit.Location = new System.Drawing.Point(168, 504);
            this.cbGenderEdit.Name = "cbGenderEdit";
            this.cbGenderEdit.Size = new System.Drawing.Size(306, 24);
            this.cbGenderEdit.TabIndex = 20;
            // 
            // tbPhoneEdit
            // 
            this.tbPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneEdit.Location = new System.Drawing.Point(168, 395);
            this.tbPhoneEdit.Name = "tbPhoneEdit";
            this.tbPhoneEdit.Size = new System.Drawing.Size(306, 28);
            this.tbPhoneEdit.TabIndex = 19;
            this.tbPhoneEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // tbEmailEdit
            // 
            this.tbEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailEdit.Location = new System.Drawing.Point(168, 287);
            this.tbEmailEdit.Name = "tbEmailEdit";
            this.tbEmailEdit.Size = new System.Drawing.Size(306, 28);
            this.tbEmailEdit.TabIndex = 18;
            // 
            // tbNameEdit
            // 
            this.tbNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameEdit.Location = new System.Drawing.Point(168, 179);
            this.tbNameEdit.Name = "tbNameEdit";
            this.tbNameEdit.Size = new System.Drawing.Size(306, 28);
            this.tbNameEdit.TabIndex = 17;
            this.tbNameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // tbUIDEdit
            // 
            this.tbUIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUIDEdit.Location = new System.Drawing.Point(168, 80);
            this.tbUIDEdit.Name = "tbUIDEdit";
            this.tbUIDEdit.Size = new System.Drawing.Size(306, 28);
            this.tbUIDEdit.TabIndex = 16;
            this.tbUIDEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(61, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(61, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "UID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 762);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageStudents";
            this.Text = "Manage Students";
            this.tabControl1.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpAddStudents.ResumeLayout(false);
            this.tpAddStudents.PerformLayout();
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpAddStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox cbGenderEdit;
        private System.Windows.Forms.TextBox tbPhoneEdit;
        private System.Windows.Forms.TextBox tbEmailEdit;
        private System.Windows.Forms.TextBox tbNameEdit;
        private System.Windows.Forms.TextBox tbUIDEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbGetStudent;
        private System.Windows.Forms.Button btDeleteStudent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
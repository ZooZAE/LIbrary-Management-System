namespace LMS
{
    partial class ManageBooks
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
            this.components = new System.ComponentModel.Container();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpSearchBooks = new System.Windows.Forms.TabPage();
            this.btSearchTitle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbSearchTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddBook = new System.Windows.Forms.TabPage();
            this.btAddBook = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tpEditBook = new System.Windows.Forms.TabPage();
            this.cbGetBook = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btDeleteBook = new System.Windows.Forms.Button();
            this.btUpdateBook = new System.Windows.Forms.Button();
            this.tbDescriptionEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYearEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAuthorEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTitleEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbISBNEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2.SuspendLayout();
            this.tpSearchBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpAddBook.SuspendLayout();
            this.tpEditBook.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpSearchBooks);
            this.tabControl2.Controls.Add(this.tpAddBook);
            this.tabControl2.Controls.Add(this.tpEditBook);
            this.tabControl2.Location = new System.Drawing.Point(11, 32);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1393, 718);
            this.tabControl2.TabIndex = 0;
            // 
            // tpSearchBooks
            // 
            this.tpSearchBooks.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a;
            this.tpSearchBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSearchBooks.Controls.Add(this.btSearchTitle);
            this.tpSearchBooks.Controls.Add(this.dataGridView2);
            this.tpSearchBooks.Controls.Add(this.tbSearchTitle);
            this.tpSearchBooks.Controls.Add(this.label1);
            this.tpSearchBooks.Location = new System.Drawing.Point(4, 25);
            this.tpSearchBooks.Name = "tpSearchBooks";
            this.tpSearchBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchBooks.Size = new System.Drawing.Size(1385, 689);
            this.tpSearchBooks.TabIndex = 0;
            this.tpSearchBooks.Text = "Search Books";
            this.tpSearchBooks.UseVisualStyleBackColor = true;
            // 
            // btSearchTitle
            // 
            this.btSearchTitle.BackColor = System.Drawing.Color.Orange;
            this.btSearchTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchTitle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSearchTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSearchTitle.Location = new System.Drawing.Point(1205, 46);
            this.btSearchTitle.Name = "btSearchTitle";
            this.btSearchTitle.Size = new System.Drawing.Size(135, 43);
            this.btSearchTitle.TabIndex = 7;
            this.btSearchTitle.Text = "Search";
            this.btSearchTitle.UseVisualStyleBackColor = false;
            this.btSearchTitle.Click += new System.EventHandler(this.btSearchTitle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(197, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(971, 534);
            this.dataGridView2.TabIndex = 6;
            // 
            // tbSearchTitle
            // 
            this.tbSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchTitle.Location = new System.Drawing.Point(197, 49);
            this.tbSearchTitle.Name = "tbSearchTitle";
            this.tbSearchTitle.Size = new System.Drawing.Size(971, 30);
            this.tbSearchTitle.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbSearchTitle, "Search by Title, Author or ISBN");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(94, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // tpAddBook
            // 
            this.tpAddBook.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a;
            this.tpAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpAddBook.Controls.Add(this.btAddBook);
            this.tpAddBook.Controls.Add(this.tbDescription);
            this.tpAddBook.Controls.Add(this.label5);
            this.tpAddBook.Controls.Add(this.tbYear);
            this.tpAddBook.Controls.Add(this.label4);
            this.tpAddBook.Controls.Add(this.tbAuthor);
            this.tpAddBook.Controls.Add(this.label3);
            this.tpAddBook.Controls.Add(this.tbTitle);
            this.tpAddBook.Controls.Add(this.label2);
            this.tpAddBook.Controls.Add(this.tbISBN);
            this.tpAddBook.Controls.Add(this.label16);
            this.tpAddBook.Location = new System.Drawing.Point(4, 25);
            this.tpAddBook.Name = "tpAddBook";
            this.tpAddBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddBook.Size = new System.Drawing.Size(1385, 689);
            this.tpAddBook.TabIndex = 1;
            this.tpAddBook.Text = "Add Book";
            this.tpAddBook.UseVisualStyleBackColor = true;
            // 
            // btAddBook
            // 
            this.btAddBook.BackColor = System.Drawing.Color.Navy;
            this.btAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddBook.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddBook.ForeColor = System.Drawing.Color.Orange;
            this.btAddBook.Location = new System.Drawing.Point(555, 545);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(313, 76);
            this.btAddBook.TabIndex = 35;
            this.btAddBook.Text = "Add Book";
            this.btAddBook.UseVisualStyleBackColor = false;
            this.btAddBook.Click += new System.EventHandler(this.btAddBook_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(539, 339);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(345, 131);
            this.tbDescription.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(397, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Description";
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.Location = new System.Drawing.Point(1003, 225);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(306, 28);
            this.tbYear.TabIndex = 32;
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(896, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Year";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.Location = new System.Drawing.Point(152, 225);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(306, 28);
            this.tbAuthor.TabIndex = 30;
            this.tbAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Author";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(1003, 96);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(306, 28);
            this.tbTitle.TabIndex = 28;
            this.tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(896, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Title";
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(152, 91);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(306, 28);
            this.tbISBN.TabIndex = 26;
            this.tbISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(45, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "ISBN";
            // 
            // tpEditBook
            // 
            this.tpEditBook.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a;
            this.tpEditBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEditBook.Controls.Add(this.cbGetBook);
            this.tpEditBook.Controls.Add(this.label30);
            this.tpEditBook.Controls.Add(this.btDeleteBook);
            this.tpEditBook.Controls.Add(this.btUpdateBook);
            this.tpEditBook.Controls.Add(this.tbDescriptionEdit);
            this.tpEditBook.Controls.Add(this.label6);
            this.tpEditBook.Controls.Add(this.tbYearEdit);
            this.tpEditBook.Controls.Add(this.label7);
            this.tpEditBook.Controls.Add(this.tbAuthorEdit);
            this.tpEditBook.Controls.Add(this.label8);
            this.tpEditBook.Controls.Add(this.tbTitleEdit);
            this.tpEditBook.Controls.Add(this.label9);
            this.tpEditBook.Controls.Add(this.tbISBNEdit);
            this.tpEditBook.Controls.Add(this.label10);
            this.tpEditBook.Location = new System.Drawing.Point(4, 25);
            this.tpEditBook.Name = "tpEditBook";
            this.tpEditBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditBook.Size = new System.Drawing.Size(1385, 689);
            this.tpEditBook.TabIndex = 2;
            this.tpEditBook.Text = "Edit Book";
            this.tpEditBook.UseVisualStyleBackColor = true;
            // 
            // cbGetBook
            // 
            this.cbGetBook.DisplayMember = "ID";
            this.cbGetBook.FormattingEnabled = true;
            this.cbGetBook.Location = new System.Drawing.Point(550, 36);
            this.cbGetBook.Name = "cbGetBook";
            this.cbGetBook.Size = new System.Drawing.Size(399, 24);
            this.cbGetBook.TabIndex = 48;
            this.cbGetBook.ValueMember = "ID";
            this.cbGetBook.SelectedIndexChanged += new System.EventHandler(this.cbGetBook_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(362, 36);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(128, 25);
            this.label30.TabIndex = 47;
            this.label30.Text = "Select Book";
            // 
            // btDeleteBook
            // 
            this.btDeleteBook.BackColor = System.Drawing.Color.Orange;
            this.btDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteBook.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteBook.ForeColor = System.Drawing.Color.Navy;
            this.btDeleteBook.Location = new System.Drawing.Point(1013, 405);
            this.btDeleteBook.Name = "btDeleteBook";
            this.btDeleteBook.Size = new System.Drawing.Size(313, 76);
            this.btDeleteBook.TabIndex = 46;
            this.btDeleteBook.Text = "Delete Book";
            this.btDeleteBook.UseVisualStyleBackColor = false;
            this.btDeleteBook.Click += new System.EventHandler(this.btDeleteBook_Click);
            // 
            // btUpdateBook
            // 
            this.btUpdateBook.BackColor = System.Drawing.Color.Navy;
            this.btUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateBook.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateBook.ForeColor = System.Drawing.Color.Orange;
            this.btUpdateBook.Location = new System.Drawing.Point(50, 405);
            this.btUpdateBook.Name = "btUpdateBook";
            this.btUpdateBook.Size = new System.Drawing.Size(313, 76);
            this.btUpdateBook.TabIndex = 45;
            this.btUpdateBook.Text = "Update Book";
            this.btUpdateBook.UseVisualStyleBackColor = false;
            this.btUpdateBook.Click += new System.EventHandler(this.btUpdateBook_Click);
            // 
            // tbDescriptionEdit
            // 
            this.tbDescriptionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptionEdit.Location = new System.Drawing.Point(561, 435);
            this.tbDescriptionEdit.Multiline = true;
            this.tbDescriptionEdit.Name = "tbDescriptionEdit";
            this.tbDescriptionEdit.Size = new System.Drawing.Size(345, 187);
            this.tbDescriptionEdit.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(418, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Description";
            // 
            // tbYearEdit
            // 
            this.tbYearEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYearEdit.Location = new System.Drawing.Point(1019, 278);
            this.tbYearEdit.Name = "tbYearEdit";
            this.tbYearEdit.Size = new System.Drawing.Size(306, 28);
            this.tbYearEdit.TabIndex = 42;
            this.tbYearEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(912, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Year";
            // 
            // tbAuthorEdit
            // 
            this.tbAuthorEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthorEdit.Location = new System.Drawing.Point(152, 283);
            this.tbAuthorEdit.Name = "tbAuthorEdit";
            this.tbAuthorEdit.Size = new System.Drawing.Size(306, 28);
            this.tbAuthorEdit.TabIndex = 40;
            this.tbAuthorEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Author";
            // 
            // tbTitleEdit
            // 
            this.tbTitleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitleEdit.Location = new System.Drawing.Point(1019, 149);
            this.tbTitleEdit.Name = "tbTitleEdit";
            this.tbTitleEdit.Size = new System.Drawing.Size(306, 28);
            this.tbTitleEdit.TabIndex = 38;
            this.tbTitleEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(912, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Title";
            // 
            // tbISBNEdit
            // 
            this.tbISBNEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBNEdit.Location = new System.Drawing.Point(152, 149);
            this.tbISBNEdit.Name = "tbISBNEdit";
            this.tbISBNEdit.Size = new System.Drawing.Size(306, 28);
            this.tbISBNEdit.TabIndex = 36;
            this.tbISBNEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(45, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "ISBN";
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
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 762);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageBooks";
            this.ShowIcon = false;
            this.Text = "ManageBooks";
            this.tabControl2.ResumeLayout(false);
            this.tpSearchBooks.ResumeLayout(false);
            this.tpSearchBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpAddBook.ResumeLayout(false);
            this.tpAddBook.PerformLayout();
            this.tpEditBook.ResumeLayout(false);
            this.tpEditBook.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpSearchBooks;
        private System.Windows.Forms.TabPage tpAddBook;
        private System.Windows.Forms.TabPage tpEditBook;
        private System.Windows.Forms.Button btSearchTitle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tbSearchTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.TextBox tbDescriptionEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYearEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAuthorEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTitleEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbISBNEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btDeleteBook;
        private System.Windows.Forms.Button btUpdateBook;
        private System.Windows.Forms.ComboBox cbGetBook;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
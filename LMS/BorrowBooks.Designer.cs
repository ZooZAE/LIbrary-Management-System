namespace LMS
{
    partial class BorrowBooks
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearchBorrowed = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btSearchID = new System.Windows.Forms.Button();
            this.tbSearchTitle = new System.Windows.Forms.TextBox();
            this.tpBorrowNew = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btReturn = new System.Windows.Forms.Button();
            this.btBorrow = new System.Windows.Forms.Button();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSearchBorrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpBorrowNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSearchBorrowed);
            this.tabControl1.Controls.Add(this.tpBorrowNew);
            this.tabControl1.Location = new System.Drawing.Point(11, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1393, 718);
            this.tabControl1.TabIndex = 1;
            // 
            // tpSearchBorrowed
            // 
            this.tpSearchBorrowed.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a2;
            this.tpSearchBorrowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSearchBorrowed.Controls.Add(this.dataGridView3);
            this.tpSearchBorrowed.Controls.Add(this.btSearchID);
            this.tpSearchBorrowed.Controls.Add(this.tbSearchTitle);
            this.tpSearchBorrowed.Location = new System.Drawing.Point(4, 25);
            this.tpSearchBorrowed.Name = "tpSearchBorrowed";
            this.tpSearchBorrowed.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchBorrowed.Size = new System.Drawing.Size(1385, 689);
            this.tpSearchBorrowed.TabIndex = 0;
            this.tpSearchBorrowed.Text = "Search Borrow";
            this.tpSearchBorrowed.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(237, 138);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(859, 545);
            this.dataGridView3.TabIndex = 11;
            // 
            // btSearchID
            // 
            this.btSearchID.BackColor = System.Drawing.Color.Yellow;
            this.btSearchID.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSearchID.ForeColor = System.Drawing.Color.DarkBlue;
            this.btSearchID.Location = new System.Drawing.Point(1144, 54);
            this.btSearchID.Name = "btSearchID";
            this.btSearchID.Size = new System.Drawing.Size(135, 43);
            this.btSearchID.TabIndex = 10;
            this.btSearchID.Text = "Search";
            this.btSearchID.UseVisualStyleBackColor = false;
            this.btSearchID.Click += new System.EventHandler(this.btSearchID_Click);
            // 
            // tbSearchTitle
            // 
            this.tbSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchTitle.Location = new System.Drawing.Point(237, 58);
            this.tbSearchTitle.Name = "tbSearchTitle";
            this.tbSearchTitle.Size = new System.Drawing.Size(860, 30);
            this.tbSearchTitle.TabIndex = 9;
            // 
            // tpBorrowNew
            // 
            this.tpBorrowNew.BackgroundImage = global::LMS.Properties.Resources.istockphoto_1133320303_170667a2;
            this.tpBorrowNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpBorrowNew.Controls.Add(this.dataGridView4);
            this.tpBorrowNew.Controls.Add(this.btReturn);
            this.tpBorrowNew.Controls.Add(this.btBorrow);
            this.tpBorrowNew.Controls.Add(this.tbBook);
            this.tpBorrowNew.Controls.Add(this.tbStudent);
            this.tpBorrowNew.Controls.Add(this.lbBooks);
            this.tpBorrowNew.Controls.Add(this.lbStudents);
            this.tpBorrowNew.Location = new System.Drawing.Point(4, 25);
            this.tpBorrowNew.Name = "tpBorrowNew";
            this.tpBorrowNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpBorrowNew.Size = new System.Drawing.Size(1385, 689);
            this.tpBorrowNew.TabIndex = 1;
            this.tpBorrowNew.Text = "Borrow Book";
            this.tpBorrowNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(81, 361);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1215, 307);
            this.dataGridView4.TabIndex = 6;
            this.dataGridView4.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_RowHeaderMouseClick);
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.Yellow;
            this.btReturn.Enabled = false;
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.ForeColor = System.Drawing.Color.DarkGreen;
            this.btReturn.Location = new System.Drawing.Point(1010, 291);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(122, 41);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btBorrow
            // 
            this.btBorrow.BackColor = System.Drawing.Color.Green;
            this.btBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrow.ForeColor = System.Drawing.Color.Yellow;
            this.btBorrow.Location = new System.Drawing.Point(237, 291);
            this.btBorrow.Name = "btBorrow";
            this.btBorrow.Size = new System.Drawing.Size(115, 41);
            this.btBorrow.TabIndex = 4;
            this.btBorrow.Text = "Borrow";
            this.btBorrow.UseVisualStyleBackColor = false;
            this.btBorrow.Click += new System.EventHandler(this.btBorrow_Click);
            // 
            // tbBook
            // 
            this.tbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBook.Location = new System.Drawing.Point(835, 167);
            this.tbBook.Name = "tbBook";
            this.tbBook.ReadOnly = true;
            this.tbBook.Size = new System.Drawing.Size(471, 30);
            this.tbBook.TabIndex = 3;
            // 
            // tbStudent
            // 
            this.tbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudent.Location = new System.Drawing.Point(835, 89);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.ReadOnly = true;
            this.tbStudent.Size = new System.Drawing.Size(471, 30);
            this.tbStudent.TabIndex = 2;
            // 
            // lbBooks
            // 
            this.lbBooks.BackColor = System.Drawing.Color.Navy;
            this.lbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooks.ForeColor = System.Drawing.SystemColors.Window;
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 25;
            this.lbBooks.Location = new System.Drawing.Point(319, 17);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(241, 254);
            this.lbBooks.TabIndex = 1;
            // 
            // lbStudents
            // 
            this.lbStudents.BackColor = System.Drawing.Color.Navy;
            this.lbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudents.ForeColor = System.Drawing.SystemColors.Window;
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 25;
            this.lbStudents.Location = new System.Drawing.Point(55, 17);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(241, 254);
            this.lbStudents.TabIndex = 0;
            // 
            // BorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 762);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BorrowBooks";
            this.Text = "BorrowBooks";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSearchBorrowed.ResumeLayout(false);
            this.tpSearchBorrowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpBorrowNew.ResumeLayout(false);
            this.tpBorrowNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSearchBorrowed;
        private System.Windows.Forms.TabPage tpBorrowNew;
        private System.Windows.Forms.Button btSearchID;
        private System.Windows.Forms.TextBox tbSearchTitle;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btBorrow;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbStudents;
    }
}
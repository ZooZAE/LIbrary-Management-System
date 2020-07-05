namespace LMS
{
    partial class DashBoard
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
            this.btManageStudents = new System.Windows.Forms.Button();
            this.btManageBooks = new System.Windows.Forms.Button();
            this.btBorrow = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(523, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Library";
            // 
            // btManageStudents
            // 
            this.btManageStudents.BackColor = System.Drawing.SystemColors.ControlText;
            this.btManageStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btManageStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btManageStudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btManageStudents.Image = global::LMS.Properties.Resources.pngbarn;
            this.btManageStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManageStudents.Location = new System.Drawing.Point(25, 147);
            this.btManageStudents.Name = "btManageStudents";
            this.btManageStudents.Size = new System.Drawing.Size(431, 234);
            this.btManageStudents.TabIndex = 1;
            this.btManageStudents.Text = "Manage Students";
            this.btManageStudents.UseVisualStyleBackColor = false;
            this.btManageStudents.Click += new System.EventHandler(this.btManageStudents_Click);
            // 
            // btManageBooks
            // 
            this.btManageBooks.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btManageBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btManageBooks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btManageBooks.Image = global::LMS.Properties.Resources.unnamed1;
            this.btManageBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManageBooks.Location = new System.Drawing.Point(481, 147);
            this.btManageBooks.Name = "btManageBooks";
            this.btManageBooks.Size = new System.Drawing.Size(449, 234);
            this.btManageBooks.TabIndex = 2;
            this.btManageBooks.Text = "Manage Books";
            this.btManageBooks.UseVisualStyleBackColor = false;
            this.btManageBooks.Click += new System.EventHandler(this.btManageBooks_Click);
            // 
            // btBorrow
            // 
            this.btBorrow.BackColor = System.Drawing.Color.DarkRed;
            this.btBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBorrow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBorrow.Image = global::LMS.Properties.Resources.book_borrowing_1501347_1271660;
            this.btBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBorrow.Location = new System.Drawing.Point(950, 147);
            this.btBorrow.Name = "btBorrow";
            this.btBorrow.Size = new System.Drawing.Size(440, 234);
            this.btBorrow.TabIndex = 4;
            this.btBorrow.Text = "Borrow Book";
            this.btBorrow.UseVisualStyleBackColor = false;
            this.btBorrow.Click += new System.EventHandler(this.btBorrow_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.Desktop;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogout.Image = global::LMS.Properties.Resources.Log_Out_Icon_4;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btLogout.Location = new System.Drawing.Point(72, 588);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(534, 162);
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Image = global::LMS.Properties.Resources.b0abc3778af56235ab2b9e499f1c1a47_off_on_power_switch_icon_512_512;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btExit.Location = new System.Drawing.Point(810, 588);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(531, 162);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1144, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "Izzat Ala Eddine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ahmad Shebbo";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.pngtree_corporate_conference_board_background_image_132253;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 762);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btBorrow);
            this.Controls.Add(this.btManageBooks);
            this.Controls.Add(this.btManageStudents);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btManageStudents;
        private System.Windows.Forms.Button btManageBooks;
        private System.Windows.Forms.Button btBorrow;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
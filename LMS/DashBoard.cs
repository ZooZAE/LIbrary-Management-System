using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudents ms = new ManageStudents();
            ms.Show();
            this.Hide();
        }

        private void btManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks mb = new ManageBooks();
            mb.Show();
            this.Hide();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowBooks bb = new BorrowBooks();
            bb.Closed += (s, args) => this.Close();
            bb.Show();
        }
    }
}

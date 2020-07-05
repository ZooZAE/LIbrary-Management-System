using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlCommand cmd;

        private void btLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter Required Fields!");
            }
            else
            {
                string Query = "SELECT count(*) from Users where Email = '"+email+"' and Password = '"+password+"'";
                if (Methods.CountWithQuery(Query) > 0)
                {
                    this.Hide();
                    DashBoard db = new DashBoard();
                    db.Closed += (s, args) => this.Close();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("User Not Found!");
                }
            }
        }

        private void btExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
            Books_Load();
            Load_Books();
        }

        SqlCommand cmd;

        //checks the keys pressed if letters only
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Books_Load()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Book", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;
        }

        private void btSearchTitle_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbSearchTitle.Text;
                if (title == "")
                {
                    Books_Load();
                }
                else
                {
                    string Query = "SELECT * from Book where Title = '" + title + "' or ISBN = '" + title + "' or Author = '" + title + "'";
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
                    SqlCommand cmd = new SqlCommand(Query, con);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            string isbn = tbISBN.Text;
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string description = tbDescription.Text;
            string year = tbYear.Text;
            if (isbn == "" || title == "" || author == "" || year == "" || description == "")
            {
                MessageBox.Show("Please Enter all Fields!");
            }
            else
            {
                string Query = "INSERT INTO Book([ISBN],[Title],[Author],[Description],[Year],[Available]) VALUES('" + isbn + "','" + title + "','" + author + "','" + description + "','" + year +"', 1)";
                Methods.CRUD(Query, cmd);
                MessageBox.Show("Book Added Successfully!");
                Clear();
                Books_Load();
                Load_Books();
            }
        }

        private void Clear()
        {
            tbISBN.Text = "";
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbYear.Text = "";
            tbDescription.Text = "";
        }

        private void ClearEdit()
        {
            tbISBNEdit.Text = "";
            tbTitleEdit.Text = "";
            tbAuthorEdit.Text = "";
            tbYearEdit.Text = "";
            tbDescriptionEdit.Text = "";
        }

        private void cbGetBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string title = cbGetBook.SelectedItem.ToString();
                string querygetID = "Select ID from Book where Title = '" + title + "'";
                string id = Methods.GetData(querygetID, cmd, "ID");
                string Query = "SELECT * from Book where id = '" + id + "'";
                tbISBNEdit.Text = Methods.GetData(Query, cmd, "ISBN");
                tbAuthorEdit.Text = Methods.GetData(Query, cmd, "Author");
                tbTitleEdit.Text = Methods.GetData(Query, cmd, "Title");
                tbYearEdit.Text = Methods.GetData(Query, cmd, "Year");
                tbDescriptionEdit.Text = Methods.GetData(Query, cmd, "Description");
            }
            catch (Exception ex)
            {

            }
        }

        private void Load_Books()
        {
            cbGetBook.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            cmd = new SqlCommand("Select Title from Book", con);
            string txt = "";
            try
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        txt = sdr["Title"].ToString();
                        cbGetBook.Items.Add(txt);
                    }
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            con.Close();
        }

        private void btUpdateBook_Click(object sender, EventArgs e)
        {
            string isbn = tbISBNEdit.Text;
            string title = tbTitleEdit.Text;
            string author = tbAuthorEdit.Text;
            string description = tbDescriptionEdit.Text;
            string year = tbYearEdit.Text;
            if (isbn == "" || title == "" || author == "" || year == "" || description == "")
            {
                MessageBox.Show("Please Enter all Fields!");
            }
            else
            {
                string Query = "UPDATE Book SET ISBN = '" + isbn + "', Title = '" + title + "', Author = '" + author + "', Description = '" + description + "', Year = '" + year + "' where Title = '" + cbGetBook.SelectedItem.ToString() + "'";
                Methods.CRUD(Query, cmd);
                MessageBox.Show("Book Updated Successfully!");
                cbGetBook.SelectedIndex = -1;
                Books_Load();
                Load_Books();
                ClearEdit();
            }
        }

        private void btDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = cbGetBook.SelectedItem.ToString();
                string querygetID = "Select ID from Book where Title = '" + title + "'";
                string id = Methods.GetData(querygetID, cmd, "ID");
                string Query = "DELETE from Book where ID = '" + id + "'";
                Methods.CRUD(Query, cmd);
                cbGetBook.SelectedIndex = -1;
                Load_Books();
                Books_Load();
                ClearEdit();
                MessageBox.Show("Book Deleted Successfully!");
            }
            catch (Exception ex)
            {
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard db = new DashBoard();
            db.Closed += (s, args) => this.Close();
            db.Show();
        }
    }
}

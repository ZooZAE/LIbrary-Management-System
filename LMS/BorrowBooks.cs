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
    public partial class BorrowBooks : Form
    {
        public BorrowBooks()
        {
            InitializeComponent();
            BorrowBooks_Load();
            Load_Students();
            Load_Books();
        }

        SqlCommand cmd;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard db = new DashBoard();
            db.Closed += (s, args) => this.Close();
            db.Show();
        }

        private void BorrowBooks_Load()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT Book.Title as Book_Title, Student.Name as Student_Name, Borrowed.Due_Date FROM Borrowed JOIN Book ON Book.ID = Borrowed.Book_ID JOIN Student ON Student.ID = Borrowed.Student_ID", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dataGridView3.DataSource = dt;
            dataGridView3.Columns[0].Width = 200;
            dataGridView3.Columns[1].Width = 200;
            dataGridView3.Columns[2].Width = 200;

            dataGridView4.DataSource = dt;
            dataGridView4.Columns[0].Width = 289;
            dataGridView4.Columns[1].Width = 289;
            dataGridView4.Columns[2].Width = 289;
        }

        private void Load_Students()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Student", con);
            string txt = "";
            try
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        txt = sdr["Name"].ToString();
                        lbStudents.Items.Add(txt);
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

        private void Load_Books()
        {
            lbBooks.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Book where Available = 1", con);
            string txt = "";
            try
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        txt = sdr["Title"].ToString();
                        lbBooks.Items.Add(txt);
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

        private void btBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbStudents.SelectedIndex == -1 || lbBooks.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select a Student and a Book!");
                }
                else
                {
                    string student = lbStudents.SelectedItem.ToString();
                    string book = lbBooks.SelectedItem.ToString();
                    string StudentID = Methods.GetData("Select ID from Student where Name = '" + student + "'", cmd, "ID");
                    string BookID = Methods.GetData("Select ID from Book where Title = '" + book + "'", cmd, "ID");
                    string Query = "INSERT INTO Borrowed(Book_ID, Student_ID, Due_Date) VALUES('" + BookID + "','" + StudentID + "','" + DateTime.Today.AddDays(3).ToShortDateString() + "')";
                    string availableBook = "UPDATE Book set Available = 0 where ID = '" + BookID + "'";
                    Methods.CRUD(Query, cmd);
                    Methods.CRUD(availableBook, cmd);
                    MessageBox.Show("Book Borrowed!");
                    Load_Books();
                    BorrowBooks_Load();
                    lbBooks.SelectedIndex = -1;
                    lbStudents.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbStudent.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbBook.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            btReturn.Enabled = true;
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbBook.Text != "" || tbStudent.Text != "")
                {
                    string book = tbBook.Text;
                    string BookID = Methods.GetData("Select ID from Book where Title = '" + book + "'", cmd, "ID");
                    string Query = "DELETE from Borrowed where Book_ID = '" + BookID + "'";
                    Methods.CRUD(Query, cmd);
                    string availableBook = "UPDATE Book set Available = 1 where ID = '" + BookID + "'";
                    Methods.CRUD(availableBook, cmd);
                    MessageBox.Show("Book was Returned!");
                    Load_Books();
                    BorrowBooks_Load();
                    tbBook.Text = "";
                    tbStudent.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Select a Book to Return from The Table Below!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btSearchID_Click(object sender, EventArgs e)
        {
            if (tbSearchTitle.Text == "")
            {
                BorrowBooks_Load();
            }
            else
            {
                string search = tbSearchTitle.Text;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT Book.Title as Book_Title, Student.Name as Student_Name, Borrowed.Due_Date FROM Borrowed JOIN Book ON Book.ID = Borrowed.Book_ID JOIN Student ON Student.ID = Borrowed.Student_ID where Book.Title = '" + search + "' or Student.Name = '" + search + "'", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                tbSearchTitle.Text = "";

                dataGridView3.DataSource = dt;
                dataGridView3.Columns[0].Width = 200;
                dataGridView3.Columns[1].Width = 200;
                dataGridView3.Columns[2].Width = 200;
            }
        }
    }
}

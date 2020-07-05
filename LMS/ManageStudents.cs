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
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
            Students_Load();
            Load_Students();
        }

        SqlCommand cmd;

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            string uid = tbUID.Text;
            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            if (uid == "" || name == "" || email == "" || phone == "" || cbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter all Fields!");
            }
            else
            {
                string Query = "INSERT INTO Student([UID],[Name],[Email],[Phone],[Gender]) VALUES('" + uid +  "','" + name + "','" + email + "','" + phone + "','" + cbGender.SelectedItem.ToString() + "')";
                Methods.CRUD(Query, cmd);
                MessageBox.Show("Student added Successfully!");
                Clear();
                Students_Load();
                Load_Students();
            }
        }

        //checks the keys pressed if letters only
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Students_Load()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Student", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void Clear()
        {
            tbUID.Text = "";
            tbName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            cbGender.SelectedIndex = -1;
        }

        private void ClearEdit()
        {
            tbUIDEdit.Text = "";
            tbNameEdit.Text = "";
            tbEmailEdit.Text = "";
            tbPhoneEdit.Text = "";
            cbGenderEdit.SelectedIndex = -1;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSearch.Text == "")
                {
                    Students_Load();
                }
                else
                {
                    string uid = tbSearch.Text;
                    string Query = "SELECT * from Student where UID = '" + uid + "'";
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
                    SqlCommand cmd = new SqlCommand(Query, con);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = dt;
                }
            }catch(Exception ex) {
            }
        }

        private void cbGetStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string name = cbGetStudent.SelectedItem.ToString();
                string querygetID = "Select ID from Student where Name = '" + name + "'";
                string id = Methods.GetData(querygetID, cmd, "ID");
                string Query = "SELECT * from Student where id = '"+id+"'";
                tbUIDEdit.Text = Methods.GetData(Query,cmd,"UID");
                tbNameEdit.Text = Methods.GetData(Query, cmd, "Name");
                tbEmailEdit.Text = Methods.GetData(Query, cmd, "Email");
                tbPhoneEdit.Text = Methods.GetData(Query, cmd, "Phone");
                if (Methods.GetData(Query, cmd, "Gender") == "Male")
                {
                    cbGenderEdit.SelectedIndex = 0;
                }
                else
                {
                    cbGenderEdit.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string uid = tbUIDEdit.Text;
            string name = tbNameEdit.Text;
            string email = tbEmailEdit.Text;
            string phone = tbPhoneEdit.Text;
            if (uid == "" || name == "" || email == "" || phone == "" || cbGenderEdit.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter all Fields!");
            }
            else
            {
                string Query = "UPDATE Student SET UID = '" + uid + "', Name = '" + name + "', Email = '" + email + "', Phone = '" + phone + "', Gender = '" + cbGenderEdit.SelectedItem.ToString() + "' where Name = '" + cbGetStudent.SelectedItem.ToString() + "'";
                Methods.CRUD(Query, cmd);
                MessageBox.Show("Student Updated Successfully!");
                cbGetStudent.SelectedIndex = -1;
                Students_Load();
                Load_Students();
                ClearEdit();
            }
        }

        private void Load_Students()
        {
            cbGetStudent.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            cmd = new SqlCommand("Select Name from Student", con);
            string txt = "";
            try
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        txt = sdr["Name"].ToString();
                        cbGetStudent.Items.Add(txt);
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

        private void btDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = cbGetStudent.SelectedItem.ToString();
                string querygetID = "Select ID from Student where Name = '" + name + "'";
                string id = Methods.GetData(querygetID, cmd, "ID");
                string Query = "DELETE  from Student where ID = '" + id + "'";
                Methods.CRUD(Query, cmd);
                cbGetStudent.SelectedIndex = -1;
                Load_Students();
                Students_Load();
                ClearEdit();
                MessageBox.Show("Student Deleted Successfully!");
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

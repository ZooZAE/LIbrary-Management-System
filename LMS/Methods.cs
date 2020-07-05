using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    class Methods
    {
        public static void CRUD(string query, SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static string GetData(string query, SqlCommand cmd, String column)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            cmd = new SqlCommand(query, con);
            string txt = "";
            try
            {
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        txt = sdr[column].ToString();
                    }
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            con.Close();
            return txt;
        }

        public static int CountWithQuery(string query)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString);
            con.Open();


            SqlCommand cmd = new SqlCommand(query, con);


            int rowsAmount = (int)cmd.ExecuteScalar();
            con.Close();

            return rowsAmount;
        }
    }
}

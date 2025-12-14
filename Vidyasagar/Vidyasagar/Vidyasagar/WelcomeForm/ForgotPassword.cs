using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vidyasagar
{
    public partial class ForgotPassword : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");
        //SqlConnection con2 = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public ForgotPassword()
        {
            InitializeComponent();
        }

        public delegate void RemoveAndLogin(Object sender);
        public event RemoveAndLogin RemoveAndLog;

        private void myButton2_Click(object sender, EventArgs e)
        {
            RemoveAndLog(this);
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            if (C_TextBox.Texts != null && e_TextBox.Texts != null && np_TextBox.Texts != null && cp_TextBox.Texts != null && np_TextBox.Texts == cp_TextBox.Texts)
            {
                string query = "Select Count(*) from Login_Info where Email='" + e_TextBox.Texts + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string query_n = "Select Count(*) from Customer_Info where Customer_Email='" + e_TextBox.Texts + "' and Customer_Phone_Number='" + C_TextBox.Texts + "'";
                SqlDataAdapter sda_n = new SqlDataAdapter(query_n, con);
                DataTable dt_n = new DataTable();
                sda_n.Fill(dt_n);

                if (dt.Rows[0][0].ToString() == "1" && dt_n.Rows[0][0].ToString() == "1")
                {
                    string query2 = "Select * from Login_Info where Email='" + e_TextBox.Texts + "'";
                    
                     SqlCommand command = new SqlCommand(query2, con);
                     SqlDataReader dr;

                     con.Open();
                     dr = command.ExecuteReader();


                     while (dr.Read())
                     {

                        string a_status = dr.GetString(4);

                         if (a_status == "leave" || a_status == "Activated")
                         {
                            string query_u = "Update Login_Info set Password=@Password where Email=@Email";
                            SqlCommand cmd = new SqlCommand(query_u, con);

                            cmd.Parameters.AddWithValue("@Email", e_TextBox.Texts);
                            cmd.Parameters.AddWithValue("@Password", np_TextBox.Texts);

                            con.Close();
                            
                            con.Open();
                            if (con.State == ConnectionState.Open)
                            {
                                
                                int rows = cmd.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    MessageBox.Show("Updated Successfully!!!");

                                    clear_Data();
                                }
                            }
                            con.Close();
                            break;
                         }
                            else MessageBox.Show("Don't Allow to change!!!");
                     }
                     con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Wrong Credentials!!!\nTry again.");
                }
            }
        }

        void clear_Data()
        {
            C_TextBox.Texts = null;
            e_TextBox.Texts = null;
            np_TextBox.Texts = null;
            cp_TextBox.Texts = null;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                cp_TextBox.PasswordChar = false;
            }
            else
            {
                cp_TextBox.PasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                np_TextBox.PasswordChar = false;
            }
            else
            {
                np_TextBox.PasswordChar = true;
            }
        }
    }
}

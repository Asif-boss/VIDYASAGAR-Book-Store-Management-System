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
    public partial class Login : UserControl
    {
        public string p_email { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                myTextBox2.PasswordChar = false;
            }
            else
            {
                myTextBox2.PasswordChar = true;
            }
        }

        public delegate void RemoveAndForgotPassword(Object sender);
        public event RemoveAndForgotPassword RemoveAndForgotPass;

        private void label4_Click(object sender, EventArgs e)
        {
            RemoveAndForgotPass(this);
        }

        public delegate void RemoveAndLogin(Object sender);
        public event RemoveAndLogin RemoveAndSign;

        private void label6_Click(object sender, EventArgs e)
        {
            RemoveAndSign(this);
        }

        public delegate void LoginAndClose(Object sender);
        public event RemoveAndLogin LoginAndCloseWindow;

        public delegate void LoginAsAdmin(Object sender);
        public event LoginAsAdmin LoginToAdminWindow;
        public event LoginAsAdmin LoginAsOwner;

        private void myButton2_Click(object sender, EventArgs e)
        {
            if(myTextBox1.Texts != null && myTextBox2.Texts != null)
            {
                string query = "Select Count(*) from Login_Info where Email='" + myTextBox1.Texts + "' and Password='" + myTextBox2.Texts + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    string query2 = "Select * from Login_Info where Email='" + myTextBox1.Texts + "' and Password='" + myTextBox2.Texts + "'";
                    SqlCommand command = new SqlCommand(query2, con);
                    SqlDataReader dr;

                    con.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        string account_Type = dr.GetString(3);
                        string status = dr.GetString(4);

                        if (status == "Activated")
                        {
                            p_email = myTextBox1.Texts;
                            if (account_Type == "Customer") LoginAndCloseWindow(this);                            
                            else LoginToAdminWindow(this);
                        }
                        else if (status == "Owner") LoginAsOwner(this);
                        else if(status == "Pending") MessageBox.Show("Wait for the approval!!!");
                        else if (status == "Banned") MessageBox.Show("You have been banned!!!");
                        else if (status == "leave") MessageBox.Show("Creat an customer account...!!!");
                        /*{
                            p_email = myTextBox1.Texts;
                            LoginAndCloseWindow(this);
                        }*/
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Credentials!!!\nTry again.");
                }
            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

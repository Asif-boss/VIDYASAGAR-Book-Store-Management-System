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
using System.IO;


namespace Vidyasagar
{
    public partial class SignUp : UserControl
    {
        string image = null;
        string U_gender = null;
        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public SignUp()
        {
            InitializeComponent();
        }

        public delegate void RemoveAndLogin (Object sender);
        public event RemoveAndLogin RemoveAndLog;
        private void myButton1_Click(object sender, EventArgs e)
        {
            RemoveAndLog(this);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            RemoveAndLog(this);
        }

        private void add_Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                image = file.FileName.ToString();
                pictureBox1.ImageLocation = image;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            U_Name.Texts = null;
            U_gender = null;
            c_TextBox.Texts = null;
            e_TextBox.Texts = null;
            dateTimePicker1.Text = null;
            image = null;
            p_TextBox.Texts = null;
            pictureBox1.Image = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            U_gender = "Female";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            U_gender = "Male";
        }

        bool CheckEmali()
        {
            string query = "Select * from Login_Info where Email='" + e_TextBox.Texts + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {
                if (dt.Rows[0][0].ToString() == "1") return false;
            }
            catch (Exception exe)
            {
                return true;
            }
            return true;

        }

        private void signup1_Click(object sender, EventArgs e)
        {
            string user_Name = U_Name.Texts;
            string user_Phone = c_TextBox.Texts;
            string user_email = e_TextBox.Texts;
            string user_password = p_TextBox.Texts;

            if (CheckEmali() == true && user_Name.Length > 0 && U_gender != null && user_Phone.Length > 0 && user_email.Length > 0 && dateTimePicker1.Text != null && user_password.Length > 0)
            {
                try
                {
                    string query1;

                    if (image != null)
                    {
                        query1 = "Insert into Customer_Info(Customer_Name, Customer_Gender, Customer_Phone_Number, Customer_Email, Customer_DOB, Customer_Pic)values(@Customer_Name, @Customer_Gender, @Customer_Phone_Number, @Customer_Email, @Customer_DOB, @Customer_Pic)";

                        byte[] pic = null;
                        FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        pic = brs.ReadBytes((int)stream.Length);

                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.Parameters.AddWithValue("@Customer_Name", U_Name.Texts);
                        cmd1.Parameters.AddWithValue("@Customer_Gender", U_gender);
                        cmd1.Parameters.AddWithValue("@Customer_Phone_Number", c_TextBox.Texts);
                        cmd1.Parameters.AddWithValue("@Customer_Email", e_TextBox.Texts);
                        cmd1.Parameters.AddWithValue("@Customer_DOB", dateTimePicker1.Value.ToString());
                        cmd1.Parameters.AddWithValue("@Customer_Pic", pic);

                        con.Open();

                        if (con.State == ConnectionState.Open)
                        {
                            int rows = cmd1.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("User info update");
                            }
                        }

                        con.Close();
                    }
                    else
                    {
                        query1 = "Insert into Customer_Info(Customer_Name, Customer_Gender, Customer_Phone_Number, Customer_Email, Customer_DOB)values(@Customer_Name, @Customer_Gender, @Customer_Phone_Number, @Customer_Email, @Customer_DOB)";

                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.Parameters.AddWithValue("@Customer_Name", U_Name.Texts);
                        cmd1.Parameters.AddWithValue("@Customer_Gender", U_gender);
                        cmd1.Parameters.AddWithValue("@Customer_Phone_Number", c_TextBox.Texts);
                        cmd1.Parameters.AddWithValue("@Customer_Email", e_TextBox.Texts);
                        cmd1.Parameters.AddWithValue("@Customer_DOB", dateTimePicker1.Value.ToString());

                        con.Open();

                        if (con.State == ConnectionState.Open)
                        {
                            int rows = cmd1.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("User info update");
                            }
                        }

                        con.Close();
                    }

                    string query2 = "Insert into Login_Info (Email, Password, Account_Type, Status)values(@Email, @Password, @Account_Type, @Status)";
                    SqlCommand cmd2 = new SqlCommand(query2, con);

                    cmd2.Parameters.AddWithValue("@Email", e_TextBox.Texts);
                    cmd2.Parameters.AddWithValue("@Password", p_TextBox.Texts);
                    cmd2.Parameters.AddWithValue("@Account_Type", "Customer");
                    cmd2.Parameters.AddWithValue("@Status", "Pending");


                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        int rows = cmd2.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Log update");
                        }
                    }
                    Clear();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error!!!");
                }
                finally
                {
                    con.Close();
                }
            }
            else if (CheckEmali() == false) MessageBox.Show("This email is already used!!!");
            else MessageBox.Show("Fill all required info(*)");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                p_TextBox.PasswordChar = false;
            }
            else
            {
                p_TextBox.PasswordChar = true;
            }
        }
    }
}

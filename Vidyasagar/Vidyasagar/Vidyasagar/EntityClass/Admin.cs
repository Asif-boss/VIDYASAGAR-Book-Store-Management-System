using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows;

namespace Vidyasagar.EntityClass
{
    interface Icustomer_data_operation
    {
        DataTable All_Customer_Data();
        bool update_log_Info(string s, string email);
        DataTable Customer_Info_Search(string Customer_ID, string Customer_Name, string Customer_Gender, string Customer_Phone_Number, string Customer_Email);
    }
    interface Iadmin_data_operation
    {
        DataTable all_Admin_Info();
        DataTable Admin_Info_Search(string Adminr_ID, string Admin_Name, string Admin_Gender, string Admin_Phone_Number, string Admin_Email);
        bool update_Admin_Info_With_Pic(string image, string email);
        bool Add_New_Admin(string image, string Admin_Name, string Admin_Gender, string Admin_Phone_Number, string Admin_Email, string Admin_DOB, string Password);
        bool Check_Log_Email(string email);
        
    }

    interface Ibook_data_operation
    {
        bool add_Book(string image, string b_name, string a_name, string b_price, string b_discount, string b_stock, string p_date, string b_sell);
        DataTable load_Book_Info();
        DataTable Search_Book_Info(string search_B);
        bool delete_Book(string Book_ID);
        bool updat_Book_Info(string image, string b_name, string a_name, string b_price, string b_discount, string b_stock, string p_date, string b_id);
    }




    public class Admin : Parents, Iadmin_data_operation, Icustomer_data_operation, Ibook_data_operation
    {
        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public Admin() { }

        public Admin(string email)
        {
            this.email = email;
            all_Info();
        }

        public override void all_Info()
        {
            string query = "Select * from Admin_Info where Admin_Email='" + email + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr;

            con.Open();
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                this.name = dr.GetString(1);
                this.gender = dr.GetString(2);
                this.phone = dr.GetString(3);
                this.DOB = dr.GetValue(6).ToString();
            }

            con.Close();
        }

        public DataTable All_Customer_Data()
        {
            DataTable dt = new DataTable();
            string query = "Select Customer_Info.*, Login_Info.Status from Customer_Info , Login_Info where Customer_Info.Customer_Email = Login_Info.Email";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);

            return dt;
        }

        public bool update_log_Info(string s, string email)
        {
            bool success = false;
            try
            {
                string query = "Update Login_Info set Status=@Status where Email=@Email";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Status", s);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        success = true;
                    }
                }

            }
            catch (Exception excep)
            {
                
            }
            finally
            {
                con.Close();
            }
            return success;
        }

        public DataTable Customer_Info_Search(string Customer_ID, string Customer_Name, string Customer_Gender, string Customer_Phone_Number, string Customer_Email)
        {
            string query = "Select Customer_Info.*, Login_Info.Status from Customer_Info , Login_Info where Customer_Info.Customer_Email = Login_Info.Email and (Customer_ID like '%" + Customer_ID + "%' or Customer_Name like '%" + Customer_Name + "%' or Customer_Gender like '" + Customer_Gender + "%' or Customer_Phone_Number like '%" + Customer_Phone_Number + "%' or Customer_Email like '%" + Customer_Email + "%')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public DataTable all_Admin_Info()
        {
            DataTable dt = new DataTable();
            string query = "Select Admin_Info.*, Login_Info.Status, Login_Info.Password from Admin_Info, Login_Info where Admin_Info.Admin_Email = Login_Info.Email";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);

            return dt;
        }

        public DataTable Admin_Info_Search(string Adminr_ID, string Admin_Name, string Admin_Gender, string Admin_Phone_Number, string Admin_Email)
        {
            string query = "Select Admin_Info.*, Login_Info.Status, Login_Info.Password from Admin_Info, Login_Info where Admin_Info.Admin_Email = Login_Info.Email and (Admin_ID like '%" + Adminr_ID + "%' or Admin_Name like '%" + Admin_Name + "%' or Admin_Gender like '" + Admin_Gender + "%' or Admin_Phone_Number like '%" + Admin_Phone_Number + "%' or Admin_Email like '%" + Admin_Email + "%')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public bool update_Admin_Info_With_Pic(string image, string email)
        {
            bool success = false;
            try
            {
                byte[] pic = null;
                FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                pic = brs.ReadBytes((int)stream.Length);

                string query = "Update Admin_Info set Admin_Pic=@Admin_Pic where Admin_Email=@Email";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Admin_Pic", pic);

                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception excep)
            {
                
            }
            finally
            {
                con.Close();
            }

            return success;
        }

        public bool Add_New_Admin(string image, string Admin_Name, string Admin_Gender, string Admin_Phone_Number, string Admin_Email, string Admin_DOB, string Password)
        {
            bool success = false;
            try
            {
                string query1;

                if (image != null)
                {
                    query1 = "Insert into Admin_Info(Admin_Name, Admin_Gender, Admin_Phone_Number, Admin_Email, Admin_DOB, Admin_Pic)values(@Admin_Name, @Admin_Gender, @Admin_Phone_Number, @Admin_Email, @Admin_DOB, @Admin_Pic)";

                    byte[] pic = null;
                    FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    pic = brs.ReadBytes((int)stream.Length);


                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("@Admin_Name", Admin_Name);
                    cmd1.Parameters.AddWithValue("@Admin_Gender", Admin_Gender);
                    cmd1.Parameters.AddWithValue("@Admin_Phone_Number", Admin_Phone_Number);
                    cmd1.Parameters.AddWithValue("@Admin_Email", Admin_Email);
                    cmd1.Parameters.AddWithValue("@Admin_DOB", Admin_DOB);
                    cmd1.Parameters.AddWithValue("@Admin_Pic", pic);

                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        int rows = cmd1.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            success = true;
                        }
                    }

                    con.Close();
                }
                else
                {
                    query1 = "Insert into Admin_Info(Admin_Name, Admin_Gender, Admin_Phone_Number, Admin_Email, Admin_DOB)values(@Admin_Name, @Admin_Gender, @Admin_Phone_Number, @Admin_Email, @Admin_DOB)";

                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("@Admin_Name", Admin_Name);
                    cmd1.Parameters.AddWithValue("@Admin_Gender", Admin_Gender);
                    cmd1.Parameters.AddWithValue("@Admin_Phone_Number", Admin_Phone_Number);
                    cmd1.Parameters.AddWithValue("@Admin_Email", Admin_Email);
                    cmd1.Parameters.AddWithValue("@Admin_DOB", Admin_DOB);

                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        int rows = cmd1.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            success = true;
                        }
                    }

                    con.Close();
                }

                string query2 = "Insert into Login_Info (Email, Password, Account_Type, Status)values(@Email, @Password, @Account_Type, @Status)";
                SqlCommand cmd2 = new SqlCommand(query2, con);

                cmd2.Parameters.AddWithValue("@Email", Admin_Name);
                cmd2.Parameters.AddWithValue("@Password", Password);
                cmd2.Parameters.AddWithValue("@Account_Type", "Admin");
                cmd2.Parameters.AddWithValue("@Status", "Activated");


                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd2.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        success = true;
                    }
                }
                
            }
            catch (Exception exc)
            {
                
            }
            finally
            {
                con.Close();
            }
            return success;
        }

        public bool Check_Log_Email(string email)
        {
            string query = "Select * from Login_Info where Email='" + email + "'";
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

            return false;
        }

        public bool add_Book(string image, string b_name, string a_name, string b_price, string b_discount, string b_stock , string p_date, string b_sell)
        {
            bool success = false;
            try
            {
                string query1 = "Insert into Book_Info(Book_Name, Author, Price, Discount, Stock, Sell, Book_Image, Publisher) values (@Book_Name, @Author, @Price, @Discount, @Stock, @Sell, @Book_Image, @Publisher)";

                byte[] pic = null;
                FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                pic = brs.ReadBytes((int)stream.Length);

                SqlCommand cmd1 = new SqlCommand(query1, con);

                cmd1.Parameters.AddWithValue("@Book_Name", b_name);
                cmd1.Parameters.AddWithValue("@Author", a_name);
                cmd1.Parameters.AddWithValue("@Price", b_price);
                cmd1.Parameters.AddWithValue("@Discount", b_discount);
                cmd1.Parameters.AddWithValue("@Stock", b_stock);
                cmd1.Parameters.AddWithValue("@Sell", b_sell);
                cmd1.Parameters.AddWithValue("@Book_Image", pic);
                cmd1.Parameters.AddWithValue("@Publisher", p_date);


                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd1.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        success = true;
                    }
                }
             }
            catch (Exception exc)
            {
               
            }
            finally
            {
                con.Close();
            }

            return success;
        }

        public DataTable load_Book_Info()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Book_Info";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);

            return dt;
        }

        public DataTable Search_Book_Info(string search_B)
        {
            string query = "Select * from Book_Info where Book_ID like '%" + search_B + "%' or Book_Name like '%" + search_B + "%' or Author like '%" + search_B + "%' or Publisher like '%" + search_B + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public bool delete_Book(string Book_ID)
        {
            bool success = false;
            try
            {
                string query = "Delete from Book_Info where Book_ID=@Book_ID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Book_ID", Book_ID);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        success = true;
                    }
                }

            }
            catch (Exception ex_1)
            {
                
            }
            finally
            {
                con.Close();
            }
            return success;
        }

        public bool updat_Book_Info(string image, string b_name, string a_name, string b_price, string b_discount, string b_stock, string p_date, string b_id)
        {
            bool success = false;
            try
            {
                if (image != null && b_id != null)
                {
                    byte[] pic = null;
                    FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    pic = brs.ReadBytes((int)stream.Length);

                    string query = "Update Book_Info set Book_Name=@Book_Name,Author=@Author,Price=@Price,Discount=@Discount,Stock=@Stock,Book_Image=@Book_Image,Publisher=@Publisher where Book_ID=@Book_ID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Book_Name", b_name);
                    cmd.Parameters.AddWithValue("@Author", a_name);
                    cmd.Parameters.AddWithValue("@Price", b_price);
                    cmd.Parameters.AddWithValue("@Discount", b_discount);
                    cmd.Parameters.AddWithValue("@Stock", b_stock);
                    cmd.Parameters.AddWithValue("@Book_Image", pic);
                    cmd.Parameters.AddWithValue("@Publisher", p_date);
                    cmd.Parameters.AddWithValue("@Book_ID", b_id);

                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            success = true;
                        }
                    }
                }
                else if (image == null && b_id != null)
                {
                    string query = "Update Book_Info set Book_Name=@Book_Name,Author=@Author,Price=@Price,Discount=@Discount,Stock=@Stock,Publisher=@Publisher where Book_ID=@Book_ID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Book_Name", b_name);
                    cmd.Parameters.AddWithValue("@Author", a_name);
                    cmd.Parameters.AddWithValue("@Price", b_price);
                    cmd.Parameters.AddWithValue("@Discount", b_discount);
                    cmd.Parameters.AddWithValue("@Stock", b_stock);
                    cmd.Parameters.AddWithValue("@Publisher", p_date);
                    cmd.Parameters.AddWithValue("@Book_ID", b_id);

                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            success = true;
                        }
                    }
                }
            }
            catch (Exception excep)
            {
                
            }
            finally
            {
                con.Close();
            }

            return success;
        }
    }
}

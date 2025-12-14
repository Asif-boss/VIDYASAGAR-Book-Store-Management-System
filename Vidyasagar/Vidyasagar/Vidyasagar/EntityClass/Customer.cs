using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace Vidyasagar.EntityClass
{
    public class Customer : Parents
    {
        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public Customer() { }
        
        public Customer(string email)
        {
            this.email = email;
            all_Info();
        }

        public override void all_Info()
        {
            string query = "Select * from Customer_Info where Customer_Email='" + email + "'";
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

    }
}

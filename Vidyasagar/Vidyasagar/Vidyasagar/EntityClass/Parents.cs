using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Vidyasagar.EntityClass
{
    abstract public class Parents
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string DOB { get; set; }

        public SqlConnection com = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public Parents() { }
        
        private Parents(string name, string gender, string phone, string email, string DOB)
        {
            this.name = name;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
            this.DOB = DOB;
        }

        public abstract void all_Info();

    }

}

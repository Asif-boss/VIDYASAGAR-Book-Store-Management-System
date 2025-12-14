using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidyasagar.BookStore
{

    public partial class CustomerInfo : UserControl
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string DOB { get; set; }

        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            info_set();
        }

        public void info_set()
        {
            customer_Name.Text = name;
            Customer_Gender.Text = gender;
            customer_Phone.Text = phone;
            customer_Email.Text = email;
            bath_Date.Text = DOB;
        }
    }
}

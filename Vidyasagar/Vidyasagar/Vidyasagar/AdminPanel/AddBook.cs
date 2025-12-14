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

namespace Vidyasagar.AdminPanel
{
    public partial class AddBook : UserControl
    {
        string image = null;
        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public AddBook()
        {
            InitializeComponent();
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

        private void AddBook_Load(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            book_Name.Texts = null;
            authorTextBox.Texts = null;
            priceTextBox.Texts = null;
            discountTextBox.Texts = null;
            image = null;
            stockTextBox.Texts = null;
            pictureBox1.Image = null;
            dateTimePicker1.Text = null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string b_name = book_Name.Texts;
            string a_name = authorTextBox.Texts;
            string b_price = priceTextBox.Texts;
            string b_discount = discountTextBox.Texts;
            string b_stock = stockTextBox.Texts;
            string p_date = dateTimePicker1.Value.ToString();
            string b_sell = "0";

            if (image != null && b_name.Length > 0 && a_name.Length > 0 && b_price.Length > 0 && b_discount.Length > 0 && b_stock.Length > 0)
            {
                if(new EntityClass.Admin().add_Book(image, b_name, a_name, b_price, b_discount, b_stock, p_date, b_sell))
                {
                    MessageBox.Show("Book has been added!!!");
                    Clear();
                }
                else MessageBox.Show("Error!!!");
            }
            else MessageBox.Show("Fill all required info(*)");
        }
    }
}

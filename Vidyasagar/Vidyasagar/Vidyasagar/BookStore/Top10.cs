using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Vidyasagar.BookStore
{
    
    public partial class Top10 : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");


        public Top10()
        {
            InitializeComponent();
            //panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            load_Top_Books();
        }

        public int quantity { get; set; }
        public double price_C { get; set; }

        void load_Top_Books()
        {
            flowLayoutPanel1.Controls.Clear();

            pictureBox1.Image = null;
            c_p_label.Text = null;
            dis_label.Text = null;
            p_label.Text = null;
            author_label.Text = null;
            numericUpDown1.Value = 0;
            price_C = 0;

            string query = "Select top 10 * from Book_Info order by Sell DESC";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr;

            con.Open();
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                int Book_ID = dr.GetInt32(0);
                string Book_Name = dr.GetString(1);
                string Author = dr.GetString(2);
                double Price1 = dr.GetDouble(3);
                float Price = (float)Price1;
                double Discount1 = dr.GetDouble(4);
                float Discount = (float)Discount1;

                BookButton b;
                try
                {
                    byte[] Book_Image_Location = (byte[])dr[7];
                    b = new BookButton(Book_ID, Book_Name, Author, Price, Discount, Book_Image_Location);
                }
                catch
                {
                    b = new BookButton(Book_ID, Book_Name, Author, Price, Discount);
                }


                flowLayoutPanel1.Controls.Add(b);
                b.Click += new EventHandler(this.b_Click);

            }
            con.Close();
        }
        void b_Click(object sender, EventArgs e)
        {
            BookButton b = (BookButton)sender;
            name.Text = b.Book_Name;
            c_p_label.Text = b.c_Price.ToString() + " BDT";
            price_C = double.Parse(b.c_Price.ToString());
            dis_label.Text = "-" + b.Discount.ToString() + "%";
            p_label.Text = b.Price.ToString() + " BDT";
            author_label.Text = b.Author;
            numericUpDown1.Value = 0;

            if (b.checker == 1)
            {
                try
                {
                    var mStream = new MemoryStream(b.Book_Image_Location);
                    pictureBox1.Image = Image.FromStream(mStream);
                }
                catch (Exception excep)
                {
                    pictureBox1.Image = null;
                }
            }
            else pictureBox1.Image = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            load_Top_Books();
        }

        private void Top10_Load(object sender, EventArgs e)
        {

        }

        public delegate void ADD_To_Cast(Object sender);
        public event ADD_To_Cast add_to_cast;

        private void myButton2_Click(object sender, EventArgs e)
        {
           // price_C = Double.Parse(c_p_label.Text);
            quantity = (int)numericUpDown1.Value;
            add_to_cast(this);
            numericUpDown1.Value = 0;
        }
    }
}

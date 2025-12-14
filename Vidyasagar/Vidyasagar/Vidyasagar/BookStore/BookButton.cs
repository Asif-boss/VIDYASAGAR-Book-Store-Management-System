using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace Vidyasagar.BookStore
{
    public partial class BookButton : UserControl
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

        internal string Book_Name;
        internal int Book_ID;
        internal string Author;
        internal float Price;
        internal float Discount;
        internal float c_Price;
        internal byte[] Book_Image_Location;
        internal int checker = 0;

        public BookButton()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
        }

        public BookButton(int Book_ID, string Book_Name, string Author, float Price, float Discount, byte[] Book_Image) : this()
        {
            this.Book_ID = Book_ID;
            this.Book_Name = Book_Name;
            this.Author = Author;
            this.Price = Price;
            this.Discount = Discount;
            this.Book_Image_Location = Book_Image;

            checker = 1;

            name.Text = Book_Name;
            c_Price = (Price - (Price * Discount / 100));
            current_Price.Text = c_Price + "BDT";
            disc.Text = "-" + Discount + "%";

            try
            {
                byte[] imgdata = Book_Image;
                var mStream = new MemoryStream(imgdata);
                pictureBox1.Image = Image.FromStream(mStream);
            }
            catch (Exception excep)
            {
                pictureBox1.Image = null;
            }
        }

        public BookButton(int Book_ID, string Book_Name, string Author, float Price, float Discount) : this()
        {
            this.Book_ID = Book_ID;
            this.Book_Name = Book_Name;
            this.Author = Author;
            this.Price = Price;
            this.Discount = Discount;

            name.Text = Book_Name;
            c_Price = (Price - (Price * Discount / 100));
            current_Price.Text = c_Price + "BDT";
            disc.Text = "-" + Discount + "%";

            pictureBox1.Image = null;
        }


        private void BookButton_Load(object sender, EventArgs e)
        {
            
        }
    }
}

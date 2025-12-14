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

namespace Vidyasagar.BookStore
{
    
    public partial class SelectedBooksButton : UserControl
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

        public string bookName { get; set; }
        public double total_price { get; set; }
        public int b_quantity { get; set; }

        public int index { get; set; }

        public SelectedBooksButton()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public SelectedBooksButton(string bookName, double total_price, int b_quantity, int index) : this()
        {
            this.bookName = bookName;
            this.total_price = total_price;
            this.b_quantity = b_quantity;
            this.index = index;

            b_name.Text = bookName;
            quantity.Text = b_quantity.ToString();
            price.Text = total_price.ToString();
        }

        private void SelectedBooksButton_Load(object sender, EventArgs e)
        {

        }

        public delegate void RemoveEventHandler(Object sender);
        public event RemoveEventHandler OnRemove;

        private void buy_Click(object sender, EventArgs e)
        {
            OnRemove(this);
        }
    }
}

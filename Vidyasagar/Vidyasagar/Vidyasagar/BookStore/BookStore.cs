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
    public partial class BookStore : Form
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

        public AdminPanel.AdminPanel adminPanel1;
        public Form1 welcomeFrom;
        public Vidyasagar.EntityClass.Admin admin;
        public EntityClass.Customer customer;


        double total_book_price = 0;
        Pay.PayWindow payBill;
        SelectedBooks sb = new SelectedBooks();
        int sButtonIndex = 0;

        public BookStore()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            this.allBook1.add_to_cast += delegate (object sender)
            {
                if (allBook1.quantity > 0)
                {
                    buy.Visible = true;
                    total_book_price += (allBook1.price_C * allBook1.quantity);

                    SelectedBooksButton sbb = new SelectedBooksButton(allBook1.name.Text, allBook1.price_C * allBook1.quantity, allBook1.quantity, sButtonIndex++);

                    sbb.OnRemove += delegate (Object s)
                    {
                        sb.flowLayoutPanel1.Controls.Remove(sbb);
                        total_book_price -= sbb.total_price;
                        sb.amount.Text = total_book_price.ToString() + " BDT";

                        if (total_book_price == 0)
                        {
                            buy.Visible = false;
                            sb.Hide();
                        }
                    };

                    sb.flowLayoutPanel1.Controls.Add(sbb);
                }
            };

            this.top101.add_to_cast += delegate (object sender)
            {
                if(top101.quantity > 0)
                {
                    buy.Visible = true;
                    total_book_price += (top101.price_C * top101.quantity);

                    SelectedBooksButton sbb = new SelectedBooksButton(top101.name.Text, top101.price_C * top101.quantity, top101.quantity, sButtonIndex++);
                    sbb.OnRemove += delegate (Object s)
                    {
                        sb.flowLayoutPanel1.Controls.Remove(sbb);
                        total_book_price -= sbb.total_price;
                        sb.amount.Text = total_book_price.ToString() + " BDT";

                        if (total_book_price == 0)
                        {
                            buy.Visible = false;
                            sb.Hide();
                        }
                    };

                    sb.flowLayoutPanel1.Controls.Add(sbb);
                }
            };

            payBill = new Pay.PayWindow();
            payBill.pay += delegate (object sender)
            {
                total_book_price = 0;
                buy.Visible = false;
                payBill.Hide();
                sb.flowLayoutPanel1.Controls.Clear();
                sb.amount.Text = total_book_price.ToString() + " BDT";
                sb.Hide();
            };

            sb.goToBuy += delegate (object sender)
            {
                payBill.addPrice(total_book_price);
                payBill.Show();
            };
        }


        public BookStore(Form1 welcomeFrom, bool visiblity, EntityClass.Customer customer) : this()
        {
            this.welcomeFrom = welcomeFrom;
            adminPanel.Visible = visiblity;
            this.customer = customer;

            customerInfo1.name = customer.name;
            customerInfo1.gender = customer.gender;
            customerInfo1.phone = customer.phone;
            customerInfo1.email = customer.email;
            customerInfo1.DOB = customer.DOB;
        }

        public BookStore(Form1 welcomeFrom, Vidyasagar.EntityClass.Admin admin) : this()
        {
            this.welcomeFrom = welcomeFrom;
            this.admin = admin;

            customerInfo1.name = admin.name;
            customerInfo1.gender = admin.gender;
            customerInfo1.phone = admin.phone;
            customerInfo1.email = admin.email;
            customerInfo1.DOB = admin.DOB;
        }

        private void BookStore_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void max_minButton_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
                this.max_minButton.IconChar = FontAwesome.Sharp.IconChar.Compress;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                this.max_minButton.IconChar = FontAwesome.Sharp.IconChar.Expand;
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Contribution Contribute = new Contribution();
            Contribute.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Book_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Vidyasagar";
            panel1.BackColor = Color.FromArgb(42, 47, 58);

            this.allBook1.Visible = true;
            this.top101.Visible = false;
            this.purchesed1.Visible = false;
            this.customerInfo1.Visible = false;

            this.Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.Book.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.Top10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Top10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.purchesed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.purchesed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void Top10_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Top 10 Books";
            this.search.Visible = false;
            this.searchBox.Visible = false;
            panel1.BackColor = Color.FromArgb(42, 47, 58);

            this.allBook1.Visible = false;
            this.top101.Visible = true;
            this.purchesed1.Visible = false;
            this.customerInfo1.Visible = false;

            this.Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Book.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.Top10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.Top10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.purchesed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.purchesed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void purchesed_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Purcgesed List";
            this.search.Visible = false;
            this.searchBox.Visible = false;

            this.allBook1.Visible = false;
            this.top101.Visible = false;
            this.purchesed1.Visible = true;
            this.customerInfo1.Visible = false;

            this.Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Book.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.Top10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Top10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.purchesed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.purchesed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void user_Click(object sender, EventArgs e)
        {
            this.label1.Text = null;
            this.search.Visible = false;
            this.searchBox.Visible = false;
            panel1.BackColor = Color.FromArgb(48, 54, 67);

            this.allBook1.Visible = false;
            this.top101.Visible = false;
            this.purchesed1.Visible = false;
            this.customerInfo1.Visible = true;

            this.Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Book.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.Top10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Top10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.purchesed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.purchesed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
        }

        private void adminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel1.Show();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            welcomeFrom.Show();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            sb.amount.Text = total_book_price.ToString() + " BDT";
            sb.Show();
        }
    }
        
}

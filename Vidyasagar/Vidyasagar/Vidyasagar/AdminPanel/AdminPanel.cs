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

namespace Vidyasagar.AdminPanel
{
    public partial class AdminPanel : Form
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

        public BookStore.BookStore bookStoreVidyasagar;
        public Form1 welcomeFrom;
        public Vidyasagar.EntityClass.Admin admin;

        public AdminPanel()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public AdminPanel(BookStore.BookStore bookStoreVidyasagar, Form1 welcomeFrom, Vidyasagar.EntityClass.Admin admin) : this()
        {
            this.bookStoreVidyasagar = bookStoreVidyasagar;
            this.welcomeFrom = welcomeFrom;
            this.admin = admin;

            personalInfo1.name = admin.name;
            personalInfo1.gender = admin.gender;
            personalInfo1.phone = admin.phone;
            personalInfo1.email = admin.email;
            personalInfo1.DOB = admin.DOB;

            //userInfo1.admin_Person = this.admin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Contribution Contribute = new Contribution();
            Contribute.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
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
                userInfo1.infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, userInfo1.infoPanel.Width, userInfo1.infoPanel.Height, 30, 30));
                userInfo1.dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, userInfo1.dataGridView1.Width, userInfo1.dataGridView1.Height, 20, 20));
                adminInfo1.infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, adminInfo1.infoPanel.Width, adminInfo1.infoPanel.Height, 30, 30));
                adminInfo1.dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, adminInfo1.dataGridView1.Width, adminInfo1.dataGridView1.Height, 20, 20));
                bookInfo1.infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bookInfo1.infoPanel.Width, bookInfo1.infoPanel.Height, 30, 30));
                bookInfo1.dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bookInfo1.dataGridView1.Width, bookInfo1.dataGridView1.Height, 20, 20));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                this.max_minButton.IconChar = FontAwesome.Sharp.IconChar.Expand;
                userInfo1.infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, userInfo1.infoPanel.Width, userInfo1.infoPanel.Height, 30, 30));
                userInfo1.dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, userInfo1.dataGridView1.Width, userInfo1.dataGridView1.Height, 20, 20));
                adminInfo1.infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, adminInfo1.infoPanel.Width, adminInfo1.infoPanel.Height, 30, 30));
                adminInfo1.dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, adminInfo1.dataGridView1.Width, adminInfo1.dataGridView1.Height, 20, 20));
                bookInfo1.infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bookInfo1.infoPanel.Width, bookInfo1.infoPanel.Height, 30, 30));
                bookInfo1.dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bookInfo1.dataGridView1.Width, bookInfo1.dataGridView1.Height, 20, 20));
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void hideButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void adminInfo_Click(object sender, EventArgs e)
        {
            this.userInfo1.Visible = false;
            this.adminInfo1.Visible = true;
            this.addAdmin1.Visible = false;
            this.addBook1.Visible = false;
            this.bookInfo1.Visible = false;
            this.personalInfo1.Visible = false;

            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void userInfo_Click(object sender, EventArgs e)
        {
            this.userInfo1.Visible = true;
            this.adminInfo1.Visible = false;
            this.addAdmin1.Visible = false;
            this.addBook1.Visible = false;
            this.bookInfo1.Visible = false;
            this.personalInfo1.Visible = false;

            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            this.userInfo1.Visible = false;
            this.adminInfo1.Visible = false;
            this.addAdmin1.Visible = true;
            this.addBook1.Visible = false;
            this.bookInfo1.Visible = false;
            this.personalInfo1.Visible = false;

            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            this.userInfo1.Visible = false;
            this.adminInfo1.Visible = false;
            this.addAdmin1.Visible = false;
            this.addBook1.Visible = true;
            this.bookInfo1.Visible = false;
            this.personalInfo1.Visible = false;

            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void bookInfo_Click(object sender, EventArgs e)
        {
            this.userInfo1.Visible = false;
            this.adminInfo1.Visible = false;
            this.addAdmin1.Visible = false;
            this.addBook1.Visible = false;
            this.bookInfo1.Visible = true;
            this.personalInfo1.Visible = false;

            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void user_Click(object sender, EventArgs e)
        {
            this.userInfo1.Visible = false;
            this.adminInfo1.Visible = false;
            this.addAdmin1.Visible = false;
            this.addBook1.Visible = false;
            this.bookInfo1.Visible = false;
            this.personalInfo1.Visible = true;

            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));

            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));

            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookStoreVidyasagar.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeFrom.Show();
        }
    }
}

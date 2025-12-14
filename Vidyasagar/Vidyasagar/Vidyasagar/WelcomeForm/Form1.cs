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


namespace Vidyasagar
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            
            Welcome welContent = new Welcome();
            welContent.Location = new Point(320, 40);
            this.Controls.Add(welContent);

            Login LogContent = new Login();
            LogContent.Location = new Point(320, 40);
            

            SignUp SignUpContent = new SignUp();
            SignUpContent.Location = new Point(320, 40);
            SignUpContent.RemoveAndLog += delegate (object sender)
            {
                this.Controls.Remove((SignUp)sender);
                this.Controls.Add(LogContent);
            };

            LogContent.RemoveAndSign += delegate (object sender)
            {
                this.Controls.Remove((Login)sender);
                this.Controls.Add(SignUpContent);
            };

            LogContent.LoginAndCloseWindow += delegate (object sender)
            {
                string A_email = LogContent.p_email;
                EntityClass.Customer c = new EntityClass.Customer(A_email);
                BookStore.BookStore bookStoreVidyasagar = new BookStore.BookStore(this, false, c);

                this.Hide();
                bookStoreVidyasagar.Show();
            };

            LogContent.LoginToAdminWindow += delegate (object sender)
            {
                string A_email = LogContent.p_email;
                Vidyasagar.EntityClass.Admin a = new Vidyasagar.EntityClass.Admin(A_email);

                BookStore.BookStore bookStoreVidyasagar = new BookStore.BookStore(this, a);
                AdminPanel.AdminPanel adminPanel = new AdminPanel.AdminPanel(bookStoreVidyasagar, this, a);

                bookStoreVidyasagar.adminPanel1 = adminPanel;

                this.Hide();
                adminPanel.Show();
            };

            LogContent.LoginAsOwner += delegate (object sender)
            {
                string A_email = LogContent.p_email;
                Vidyasagar.EntityClass.Admin a = new Vidyasagar.EntityClass.Admin(A_email);

                BookStore.BookStore bookStoreVidyasagar = new BookStore.BookStore(this, a);
                AdminPanel.AdminPanel adminPanel = new AdminPanel.AdminPanel(bookStoreVidyasagar, this, a);
                adminPanel.userInfo.Location = new Point(0, 127);
                adminPanel.adminInfo.Location = new Point(0, 192);
                adminPanel.adminInfo.Visible = true;
                adminPanel.addAdmin.Location = new Point(0, 257);
                adminPanel.addBook.Location = new Point(0, 322);
                adminPanel.bookInfo.Location = new Point(0, 387);

                bookStoreVidyasagar.adminPanel1 = adminPanel;

                this.Hide();
                adminPanel.Show();
            };

            welContent.RemoveAndLog += delegate (object sender)
            {
                this.Controls.Remove((Welcome)sender);
                this.Controls.Add(LogContent);
            };

            welContent.RemoveAndSign += delegate (object sender)
            {
                this.Controls.Remove((Welcome)sender);
                this.Controls.Add(SignUpContent);
            };

            ForgotPassword forgotPass = new ForgotPassword();
            forgotPass.Location = new Point(320, 40);
            forgotPass.RemoveAndLog += delegate (object sender)
            {
                this.Controls.Remove((ForgotPassword)sender);
                this.Controls.Add(LogContent);
            };

            LogContent.RemoveAndForgotPass += delegate (object sender)
            {
                this.Controls.Remove((Login)sender);
                this.Controls.Add(forgotPass);
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 42, 52);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(48, 54, 67);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Contribution Contribute = new Contribution();
            Contribute.Show();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

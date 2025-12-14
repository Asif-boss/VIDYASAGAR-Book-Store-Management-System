
namespace Vidyasagar.AdminPanel
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panelManu = new System.Windows.Forms.Panel();
            this.bookInfo = new FontAwesome.Sharp.IconButton();
            this.addBook = new FontAwesome.Sharp.IconButton();
            this.addAdmin = new FontAwesome.Sharp.IconButton();
            this.adminInfo = new FontAwesome.Sharp.IconButton();
            this.userInfo = new FontAwesome.Sharp.IconButton();
            this.Shop = new FontAwesome.Sharp.IconButton();
            this.user = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.hideButton = new FontAwesome.Sharp.IconPictureBox();
            this.max_minButton = new FontAwesome.Sharp.IconPictureBox();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.personalInfo1 = new Vidyasagar.AdminPanel.PersonalInfo();
            this.bookInfo1 = new Vidyasagar.AdminPanel.BookInfo();
            this.addBook1 = new Vidyasagar.AdminPanel.AddBook();
            this.addAdmin1 = new Vidyasagar.AdminPanel.AddAdmin();
            this.adminInfo1 = new Vidyasagar.AdminPanel.AdminInfo();
            this.userInfo1 = new Vidyasagar.AdminPanel.UserInfo();
            this.panelManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelManu.Controls.Add(this.userInfo);
            this.panelManu.Controls.Add(this.bookInfo);
            this.panelManu.Controls.Add(this.addBook);
            this.panelManu.Controls.Add(this.addAdmin);
            this.panelManu.Controls.Add(this.adminInfo);
            this.panelManu.Controls.Add(this.Shop);
            this.panelManu.Controls.Add(this.user);
            this.panelManu.Controls.Add(this.pictureBox1);
            this.panelManu.Controls.Add(this.logout);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(61, 576);
            this.panelManu.TabIndex = 7;
            // 
            // bookInfo
            // 
            this.bookInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookInfo.FlatAppearance.BorderSize = 0;
            this.bookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookInfo.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.bookInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.bookInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookInfo.IconSize = 25;
            this.bookInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookInfo.Location = new System.Drawing.Point(0, 355);
            this.bookInfo.Name = "bookInfo";
            this.bookInfo.Size = new System.Drawing.Size(60, 62);
            this.bookInfo.TabIndex = 16;
            this.bookInfo.Text = "Book Info";
            this.bookInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookInfo.UseVisualStyleBackColor = true;
            this.bookInfo.Click += new System.EventHandler(this.bookInfo_Click);
            // 
            // addBook
            // 
            this.addBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook.FlatAppearance.BorderSize = 0;
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.addBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBook.IconSize = 25;
            this.addBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addBook.Location = new System.Drawing.Point(0, 290);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(60, 62);
            this.addBook.TabIndex = 15;
            this.addBook.Text = "Add Book";
            this.addBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // addAdmin
            // 
            this.addAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAdmin.FlatAppearance.BorderSize = 0;
            this.addAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAdmin.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.addAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.addAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addAdmin.IconSize = 25;
            this.addAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addAdmin.Location = new System.Drawing.Point(0, 225);
            this.addAdmin.Name = "addAdmin";
            this.addAdmin.Size = new System.Drawing.Size(60, 62);
            this.addAdmin.TabIndex = 14;
            this.addAdmin.Text = "Add Admin";
            this.addAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addAdmin.UseVisualStyleBackColor = true;
            this.addAdmin.Click += new System.EventHandler(this.addAdmin_Click);
            // 
            // adminInfo
            // 
            this.adminInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminInfo.FlatAppearance.BorderSize = 0;
            this.adminInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminInfo.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.adminInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.adminInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminInfo.IconSize = 25;
            this.adminInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.adminInfo.Location = new System.Drawing.Point(0, 104);
            this.adminInfo.Name = "adminInfo";
            this.adminInfo.Size = new System.Drawing.Size(60, 62);
            this.adminInfo.TabIndex = 13;
            this.adminInfo.Text = "Admin Info";
            this.adminInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminInfo.UseVisualStyleBackColor = true;
            this.adminInfo.Visible = false;
            this.adminInfo.Click += new System.EventHandler(this.adminInfo_Click);
            // 
            // userInfo
            // 
            this.userInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfo.FlatAppearance.BorderSize = 0;
            this.userInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userInfo.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.userInfo.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.userInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.userInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userInfo.IconSize = 25;
            this.userInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userInfo.Location = new System.Drawing.Point(0, 159);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(60, 62);
            this.userInfo.TabIndex = 12;
            this.userInfo.Text = "User Info";
            this.userInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userInfo.UseVisualStyleBackColor = true;
            this.userInfo.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // Shop
            // 
            this.Shop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Shop.FlatAppearance.BorderSize = 0;
            this.Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shop.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(183)))));
            this.Shop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.Shop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(183)))));
            this.Shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Shop.IconSize = 25;
            this.Shop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Shop.Location = new System.Drawing.Point(0, 61);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(60, 46);
            this.Shop.TabIndex = 9;
            this.Shop.Text = "Shop";
            this.Shop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Shop.UseVisualStyleBackColor = true;
            this.Shop.Click += new System.EventHandler(this.Shop_Click);
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.FlatAppearance.BorderSize = 0;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconChar = FontAwesome.Sharp.IconChar.User;
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.user.IconSize = 25;
            this.user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.user.Location = new System.Drawing.Point(0, 475);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(60, 44);
            this.user.TabIndex = 8;
            this.user.Text = "User";
            this.user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Vidyasagar.Properties.Resources._35;
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.DarkRed;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logout.IconColor = System.Drawing.Color.DarkRed;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.IconSize = 25;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(0, 523);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 44);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout!";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // hideButton
            // 
            this.hideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.hideButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.hideButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.hideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hideButton.IconSize = 20;
            this.hideButton.Location = new System.Drawing.Point(860, 8);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(20, 20);
            this.hideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hideButton.TabIndex = 17;
            this.hideButton.TabStop = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click_1);
            // 
            // max_minButton
            // 
            this.max_minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max_minButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.max_minButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max_minButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.max_minButton.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.max_minButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.max_minButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.max_minButton.IconSize = 20;
            this.max_minButton.Location = new System.Drawing.Point(886, 8);
            this.max_minButton.Name = "max_minButton";
            this.max_minButton.Size = new System.Drawing.Size(20, 20);
            this.max_minButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.max_minButton.TabIndex = 18;
            this.max_minButton.TabStop = false;
            this.max_minButton.Click += new System.EventHandler(this.max_minButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 20;
            this.exitButton.Location = new System.Drawing.Point(912, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitButton.TabIndex = 17;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // personalInfo1
            // 
            this.personalInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInfo1.DOB = null;
            this.personalInfo1.email = null;
            this.personalInfo1.gender = null;
            this.personalInfo1.Location = new System.Drawing.Point(62, 28);
            this.personalInfo1.name = null;
            this.personalInfo1.Name = "personalInfo1";
            this.personalInfo1.phone = null;
            this.personalInfo1.Size = new System.Drawing.Size(881, 548);
            this.personalInfo1.TabIndex = 24;
            this.personalInfo1.Visible = false;
            // 
            // bookInfo1
            // 
            this.bookInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookInfo1.Location = new System.Drawing.Point(62, 28);
            this.bookInfo1.Name = "bookInfo1";
            this.bookInfo1.Size = new System.Drawing.Size(881, 548);
            this.bookInfo1.TabIndex = 23;
            this.bookInfo1.Visible = false;
            // 
            // addBook1
            // 
            this.addBook1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBook1.Location = new System.Drawing.Point(62, 28);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(881, 548);
            this.addBook1.TabIndex = 22;
            this.addBook1.Visible = false;
            // 
            // addAdmin1
            // 
            this.addAdmin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAdmin1.Location = new System.Drawing.Point(62, 28);
            this.addAdmin1.Name = "addAdmin1";
            this.addAdmin1.Size = new System.Drawing.Size(881, 548);
            this.addAdmin1.TabIndex = 21;
            this.addAdmin1.Visible = false;
            // 
            // adminInfo1
            // 
            this.adminInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminInfo1.Location = new System.Drawing.Point(62, 28);
            this.adminInfo1.Name = "adminInfo1";
            this.adminInfo1.Size = new System.Drawing.Size(881, 548);
            this.adminInfo1.TabIndex = 20;
            this.adminInfo1.Visible = false;
            // 
            // userInfo1
            // 
            this.userInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfo1.Location = new System.Drawing.Point(62, 28);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(881, 548);
            this.userInfo1.TabIndex = 25;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(942, 576);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.personalInfo1);
            this.Controls.Add(this.bookInfo1);
            this.Controls.Add(this.addBook1);
            this.Controls.Add(this.addAdmin1);
            this.Controls.Add(this.adminInfo1);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.panelManu);
            this.Controls.Add(this.max_minButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panelManu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelManu;
        private FontAwesome.Sharp.IconButton Shop;
        private FontAwesome.Sharp.IconButton user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton logout;
        private FontAwesome.Sharp.IconPictureBox max_minButton;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private FontAwesome.Sharp.IconPictureBox hideButton;
        private AdminInfo adminInfo1;
        private AddAdmin addAdmin1;
        private AddBook addBook1;
        private BookInfo bookInfo1;
        private PersonalInfo personalInfo1;
        private UserInfo userInfo1;
        public FontAwesome.Sharp.IconButton userInfo;
        public FontAwesome.Sharp.IconButton adminInfo;
        public FontAwesome.Sharp.IconButton addAdmin;
        public FontAwesome.Sharp.IconButton addBook;
        public FontAwesome.Sharp.IconButton bookInfo;
    }
}
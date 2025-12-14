
namespace Vidyasagar.BookStore
{
    partial class BookStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookStore));
            this.panelManu = new System.Windows.Forms.Panel();
            this.Book = new FontAwesome.Sharp.IconButton();
            this.purchesed = new FontAwesome.Sharp.IconButton();
            this.Top10 = new FontAwesome.Sharp.IconButton();
            this.adminPanel = new FontAwesome.Sharp.IconButton();
            this.user = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buy = new FontAwesome.Sharp.IconButton();
            this.hideButton = new FontAwesome.Sharp.IconPictureBox();
            this.max_minButton = new FontAwesome.Sharp.IconPictureBox();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new FontAwesome.Sharp.IconPictureBox();
            this.customerInfo1 = new Vidyasagar.BookStore.CustomerInfo();
            this.purchesed1 = new Vidyasagar.BookStore.Purchesed();
            this.top101 = new Vidyasagar.BookStore.Top10();
            this.allBook1 = new Vidyasagar.BookStore.AllBook();
            this.searchBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.panelManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelManu.Controls.Add(this.Book);
            this.panelManu.Controls.Add(this.purchesed);
            this.panelManu.Controls.Add(this.Top10);
            this.panelManu.Controls.Add(this.adminPanel);
            this.panelManu.Controls.Add(this.user);
            this.panelManu.Controls.Add(this.pictureBox1);
            this.panelManu.Controls.Add(this.logout);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(61, 520);
            this.panelManu.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book.FlatAppearance.BorderSize = 0;
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Bogart", 9F);
            this.Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.Book.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Book.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.Book.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Book.IconSize = 25;
            this.Book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Book.Location = new System.Drawing.Point(-3, 213);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(67, 44);
            this.Book.TabIndex = 12;
            this.Book.Text = "All Books";
            this.Book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // purchesed
            // 
            this.purchesed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.purchesed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchesed.FlatAppearance.BorderSize = 0;
            this.purchesed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchesed.Font = new System.Drawing.Font("Dutch801 Rm BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchesed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.purchesed.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.purchesed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.purchesed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.purchesed.IconSize = 25;
            this.purchesed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.purchesed.Location = new System.Drawing.Point(-6, 333);
            this.purchesed.Name = "purchesed";
            this.purchesed.Size = new System.Drawing.Size(73, 44);
            this.purchesed.TabIndex = 11;
            this.purchesed.Text = "Purchesed";
            this.purchesed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.purchesed.UseVisualStyleBackColor = true;
            this.purchesed.Visible = false;
            this.purchesed.Click += new System.EventHandler(this.purchesed_Click);
            // 
            // Top10
            // 
            this.Top10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Top10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Top10.FlatAppearance.BorderSize = 0;
            this.Top10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Top10.Font = new System.Drawing.Font("Bogart", 9F);
            this.Top10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Top10.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.Top10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.Top10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Top10.IconSize = 25;
            this.Top10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Top10.Location = new System.Drawing.Point(0, 264);
            this.Top10.Name = "Top10";
            this.Top10.Size = new System.Drawing.Size(60, 44);
            this.Top10.TabIndex = 10;
            this.Top10.Text = "Top 10";
            this.Top10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Top10.UseVisualStyleBackColor = true;
            this.Top10.Click += new System.EventHandler(this.Top10_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminPanel.FlatAppearance.BorderSize = 0;
            this.adminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanel.Font = new System.Drawing.Font("Bogart", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(183)))));
            this.adminPanel.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.adminPanel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(183)))));
            this.adminPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminPanel.IconSize = 25;
            this.adminPanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.adminPanel.Location = new System.Drawing.Point(0, 61);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(60, 55);
            this.adminPanel.TabIndex = 9;
            this.adminPanel.Text = "Admin Panel";
            this.adminPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminPanel.UseVisualStyleBackColor = true;
            this.adminPanel.Click += new System.EventHandler(this.adminPanel_Click);
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.FlatAppearance.BorderSize = 0;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Bogart", 9F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconChar = FontAwesome.Sharp.IconChar.User;
            this.user.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.user.IconSize = 25;
            this.user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.user.Location = new System.Drawing.Point(0, 419);
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
            this.logout.Font = new System.Drawing.Font("Bogart", 9F);
            this.logout.ForeColor = System.Drawing.Color.Crimson;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logout.IconColor = System.Drawing.Color.Crimson;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.IconSize = 25;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(0, 467);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 44);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout!";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Bogart Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(428, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vidyasagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.White;
            this.buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy.FlatAppearance.BorderSize = 0;
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("BankGothic Lt BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.buy.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.buy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.buy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buy.IconSize = 26;
            this.buy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buy.Location = new System.Drawing.Point(300, 5);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(88, 23);
            this.buy.TabIndex = 22;
            this.buy.Text = "Buy Now";
            this.buy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Visible = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
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
            this.hideButton.Location = new System.Drawing.Point(800, 8);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(20, 20);
            this.hideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hideButton.TabIndex = 6;
            this.hideButton.TabStop = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
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
            this.max_minButton.Location = new System.Drawing.Point(826, 8);
            this.max_minButton.Name = "max_minButton";
            this.max_minButton.Size = new System.Drawing.Size(20, 20);
            this.max_minButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.max_minButton.TabIndex = 5;
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
            this.exitButton.Location = new System.Drawing.Point(852, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitButton.TabIndex = 4;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.panel1.Location = new System.Drawing.Point(61, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 28);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.search.IconSize = 26;
            this.search.Location = new System.Drawing.Point(249, -1);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(26, 26);
            this.search.TabIndex = 17;
            this.search.TabStop = false;
            this.search.Visible = false;
            // 
            // customerInfo1
            // 
            this.customerInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerInfo1.DOB = null;
            this.customerInfo1.email = null;
            this.customerInfo1.gender = null;
            this.customerInfo1.Location = new System.Drawing.Point(62, 28);
            this.customerInfo1.name = null;
            this.customerInfo1.Name = "customerInfo1";
            this.customerInfo1.phone = null;
            this.customerInfo1.Size = new System.Drawing.Size(819, 492);
            this.customerInfo1.TabIndex = 21;
            this.customerInfo1.Visible = false;
            // 
            // purchesed1
            // 
            this.purchesed1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchesed1.Location = new System.Drawing.Point(62, 28);
            this.purchesed1.Name = "purchesed1";
            this.purchesed1.Size = new System.Drawing.Size(819, 492);
            this.purchesed1.TabIndex = 20;
            this.purchesed1.Visible = false;
            // 
            // top101
            // 
            this.top101.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top101.Location = new System.Drawing.Point(62, 28);
            this.top101.Name = "top101";
            this.top101.price_C = 0D;
            this.top101.quantity = 0;
            this.top101.Size = new System.Drawing.Size(819, 492);
            this.top101.TabIndex = 19;
            this.top101.Visible = false;
            // 
            // allBook1
            // 
            this.allBook1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allBook1.Location = new System.Drawing.Point(62, 28);
            this.allBook1.Name = "allBook1";
            this.allBook1.price_C = 0D;
            this.allBook1.quantity = 0;
            this.allBook1.Size = new System.Drawing.Size(819, 492);
            this.allBook1.TabIndex = 18;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.searchBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.searchBox.BorderSize = 0;
            this.searchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.searchBox.Location = new System.Drawing.Point(244, -1);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(7);
            this.searchBox.PasswordChar = false;
            this.searchBox.Size = new System.Drawing.Size(10, 30);
            this.searchBox.TabIndex = 16;
            this.searchBox.Texts = "";
            this.searchBox.UnderlinedStyle = true;
            this.searchBox.Visible = false;
            // 
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(882, 520);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerInfo1);
            this.Controls.Add(this.purchesed1);
            this.Controls.Add(this.top101);
            this.Controls.Add(this.allBook1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.max_minButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BookStore_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panelManu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManu;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private FontAwesome.Sharp.IconPictureBox max_minButton;
        private FontAwesome.Sharp.IconPictureBox hideButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton logout;
        private FontAwesome.Sharp.IconButton user;
        private FontAwesome.Sharp.IconButton Book;
        private FontAwesome.Sharp.IconButton purchesed;
        private FontAwesome.Sharp.IconButton Top10;
        private System.Windows.Forms.Label label1;
        private AllBook allBook1;
        private Top10 top101;
        private Purchesed purchesed1;
        private CustomerInfo customerInfo1;
        internal FontAwesome.Sharp.IconButton adminPanel;
        private FontAwesome.Sharp.IconButton buy;
        private CustomDesign.MyTextBox searchBox;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox search;
    }
}
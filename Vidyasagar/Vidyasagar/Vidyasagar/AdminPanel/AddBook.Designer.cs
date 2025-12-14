
namespace Vidyasagar.AdminPanel
{
    partial class AddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.add_Pic = new CustomControls.RJControls.MyButton();
            this.clear = new CustomControls.RJControls.MyButton();
            this.add = new CustomControls.RJControls.MyButton();
            this.stockTextBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.discountTextBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.priceTextBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.book_Name = new Vidyasagar.CustomDesign.MyTextBox();
            this.stock = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.authorTextBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bogart Bold", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(331, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Book!!!";
            // 
            // add_Pic
            // 
            this.add_Pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_Pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.add_Pic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.add_Pic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.add_Pic.BorderRadius = 10;
            this.add_Pic.BorderSize = 3;
            this.add_Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Pic.FlatAppearance.BorderSize = 0;
            this.add_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Pic.Font = new System.Drawing.Font("Bogart Trial", 15.75F);
            this.add_Pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.add_Pic.Location = new System.Drawing.Point(668, 324);
            this.add_Pic.Name = "add_Pic";
            this.add_Pic.Size = new System.Drawing.Size(166, 46);
            this.add_Pic.TabIndex = 113;
            this.add_Pic.Text = "Add Image*";
            this.add_Pic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.add_Pic.UseVisualStyleBackColor = false;
            this.add_Pic.Click += new System.EventHandler(this.add_Pic_Click);
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.clear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clear.BorderRadius = 10;
            this.clear.BorderSize = 0;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Bogart Trial", 15.75F);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(247, 426);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(163, 40);
            this.clear.TabIndex = 112;
            this.clear.Text = "Clear";
            this.clear.TextColor = System.Drawing.Color.White;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add.BorderRadius = 10;
            this.add.BorderSize = 0;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Bogart Trial", 15.75F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(471, 426);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(163, 40);
            this.add.TabIndex = 111;
            this.add.Text = "Add";
            this.add.TextColor = System.Drawing.Color.White;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.stockTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.stockTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.stockTextBox.BorderSize = 3;
            this.stockTextBox.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.stockTextBox.ForeColor = System.Drawing.Color.White;
            this.stockTextBox.Location = new System.Drawing.Point(342, 304);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockTextBox.Multiline = false;
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.stockTextBox.PasswordChar = false;
            this.stockTextBox.Size = new System.Drawing.Size(269, 34);
            this.stockTextBox.TabIndex = 110;
            this.stockTextBox.Texts = "";
            this.stockTextBox.UnderlinedStyle = true;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.discountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.discountTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.discountTextBox.BorderSize = 3;
            this.discountTextBox.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.discountTextBox.ForeColor = System.Drawing.Color.White;
            this.discountTextBox.Location = new System.Drawing.Point(342, 249);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountTextBox.Multiline = false;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.discountTextBox.PasswordChar = false;
            this.discountTextBox.Size = new System.Drawing.Size(269, 34);
            this.discountTextBox.TabIndex = 109;
            this.discountTextBox.Texts = "";
            this.discountTextBox.UnderlinedStyle = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.priceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.priceTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.priceTextBox.BorderSize = 3;
            this.priceTextBox.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.priceTextBox.ForeColor = System.Drawing.Color.White;
            this.priceTextBox.Location = new System.Drawing.Point(342, 194);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Multiline = false;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.priceTextBox.PasswordChar = false;
            this.priceTextBox.Size = new System.Drawing.Size(269, 34);
            this.priceTextBox.TabIndex = 108;
            this.priceTextBox.Texts = "";
            this.priceTextBox.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(691, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // book_Name
            // 
            this.book_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.book_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.book_Name.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.book_Name.BorderSize = 3;
            this.book_Name.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.book_Name.ForeColor = System.Drawing.Color.White;
            this.book_Name.Location = new System.Drawing.Point(342, 84);
            this.book_Name.Margin = new System.Windows.Forms.Padding(4);
            this.book_Name.Multiline = false;
            this.book_Name.Name = "book_Name";
            this.book_Name.Padding = new System.Windows.Forms.Padding(7);
            this.book_Name.PasswordChar = false;
            this.book_Name.Size = new System.Drawing.Size(269, 34);
            this.book_Name.TabIndex = 105;
            this.book_Name.Texts = "";
            this.book_Name.UnderlinedStyle = true;
            // 
            // stock
            // 
            this.stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.stock.Location = new System.Drawing.Point(264, 314);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(77, 19);
            this.stock.TabIndex = 104;
            this.stock.Text = "Stock:*";
            // 
            // book
            // 
            this.book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book.AutoSize = true;
            this.book.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.book.Location = new System.Drawing.Point(208, 94);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(133, 19);
            this.book.TabIndex = 99;
            this.book.Text = "Book Name:*";
            // 
            // author
            // 
            this.author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.author.Location = new System.Drawing.Point(248, 149);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(93, 19);
            this.author.TabIndex = 100;
            this.author.Text = "Author:*";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.price.Location = new System.Drawing.Point(212, 204);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(129, 19);
            this.price.TabIndex = 101;
            this.price.Text = "Price(BDT):*";
            // 
            // discount
            // 
            this.discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.discount.Location = new System.Drawing.Point(195, 259);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(146, 19);
            this.discount.TabIndex = 102;
            this.discount.Text = "Discount(%):*";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.date.Location = new System.Drawing.Point(155, 369);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(186, 19);
            this.date.TabIndex = 103;
            this.date.Text = "Publication Date:*";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.authorTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.authorTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.authorTextBox.BorderSize = 3;
            this.authorTextBox.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.authorTextBox.ForeColor = System.Drawing.Color.White;
            this.authorTextBox.Location = new System.Drawing.Point(342, 139);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.authorTextBox.Multiline = false;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.authorTextBox.PasswordChar = false;
            this.authorTextBox.Size = new System.Drawing.Size(269, 34);
            this.authorTextBox.TabIndex = 107;
            this.authorTextBox.Texts = "";
            this.authorTextBox.UnderlinedStyle = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Dutch801 Rm BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Dutch801 Rm BT", 9.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 23);
            this.dateTimePicker1.TabIndex = 114;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.add_Pic);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.book_Name);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.book);
            this.Controls.Add(this.author);
            this.Controls.Add(this.price);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(881, 548);
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.MyButton add_Pic;
        private CustomControls.RJControls.MyButton clear;
        private CustomControls.RJControls.MyButton add;
        private CustomDesign.MyTextBox stockTextBox;
        private CustomDesign.MyTextBox discountTextBox;
        private CustomDesign.MyTextBox priceTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomDesign.MyTextBox book_Name;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label book;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label date;
        private CustomDesign.MyTextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

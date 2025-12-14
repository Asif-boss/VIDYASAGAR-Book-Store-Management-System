
namespace Vidyasagar.BookStore
{
    partial class AllBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.myButton2 = new CustomControls.RJControls.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.author_label = new System.Windows.Forms.Label();
            this.p_label = new System.Windows.Forms.Label();
            this.dis_label = new System.Windows.Forms.Label();
            this.c_p_label = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.c_price = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.refresh = new CustomControls.RJControls.MyButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.myButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.author_label);
            this.panel1.Controls.Add(this.p_label);
            this.panel1.Controls.Add(this.dis_label);
            this.panel1.Controls.Add(this.c_p_label);
            this.panel1.Controls.Add(this.author);
            this.panel1.Controls.Add(this.c_price);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.discount);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 492);
            this.panel1.TabIndex = 2;
            // 
            // myButton2
            // 
            this.myButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.myButton2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.myButton2.BorderRadius = 10;
            this.myButton2.BorderSize = 0;
            this.myButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("Bogart Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(32, 435);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(163, 40);
            this.myButton2.TabIndex = 101;
            this.myButton2.Text = "Add to Cast";
            this.myButton2.TextColor = System.Drawing.Color.White;
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bogart Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(29, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(133, 408);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 21);
            this.numericUpDown1.TabIndex = 99;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // author_label
            // 
            this.author_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.author_label.Font = new System.Drawing.Font("Bogart", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_label.ForeColor = System.Drawing.Color.White;
            this.author_label.Location = new System.Drawing.Point(3, 381);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(221, 22);
            this.author_label.TabIndex = 98;
            this.author_label.Text = "Current Price";
            this.author_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_label
            // 
            this.p_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p_label.Font = new System.Drawing.Font("Bogart", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_label.ForeColor = System.Drawing.Color.White;
            this.p_label.Location = new System.Drawing.Point(3, 328);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(221, 22);
            this.p_label.TabIndex = 97;
            this.p_label.Text = "Current Price";
            this.p_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dis_label
            // 
            this.dis_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dis_label.Font = new System.Drawing.Font("Bogart", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dis_label.ForeColor = System.Drawing.Color.White;
            this.dis_label.Location = new System.Drawing.Point(3, 275);
            this.dis_label.Name = "dis_label";
            this.dis_label.Size = new System.Drawing.Size(221, 22);
            this.dis_label.TabIndex = 96;
            this.dis_label.Text = "Current Price";
            this.dis_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c_p_label
            // 
            this.c_p_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c_p_label.Font = new System.Drawing.Font("Bogart", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_p_label.ForeColor = System.Drawing.Color.White;
            this.c_p_label.Location = new System.Drawing.Point(3, 222);
            this.c_p_label.Name = "c_p_label";
            this.c_p_label.Size = new System.Drawing.Size(221, 22);
            this.c_p_label.TabIndex = 92;
            this.c_p_label.Text = "Current Price";
            this.c_p_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Bogart Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.author.Location = new System.Drawing.Point(70, 359);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(87, 19);
            this.author.TabIndex = 87;
            this.author.Text = "Author:";
            // 
            // c_price
            // 
            this.c_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c_price.AutoSize = true;
            this.c_price.Font = new System.Drawing.Font("Bogart Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.c_price.Location = new System.Drawing.Point(38, 197);
            this.c_price.Name = "c_price";
            this.c_price.Size = new System.Drawing.Size(151, 19);
            this.c_price.TabIndex = 91;
            this.c_price.Text = "Current Price:";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Bogart Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.price.Location = new System.Drawing.Point(52, 305);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(123, 19);
            this.price.TabIndex = 88;
            this.price.Text = "Main Price:";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Font = new System.Drawing.Font("Bogart Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 22);
            this.name.TabIndex = 86;
            this.name.Text = "Book";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discount
            // 
            this.discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Bogart Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.discount.Location = new System.Drawing.Point(61, 251);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(105, 19);
            this.discount.TabIndex = 89;
            this.discount.Text = "Discount:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(51, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(227, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 461);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.refresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.refresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.refresh.BorderRadius = 10;
            this.refresh.BorderSize = 0;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Bogart Trial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(651, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(148, 31);
            this.refresh.TabIndex = 59;
            this.refresh.Text = "Reload";
            this.refresh.TextColor = System.Drawing.Color.White;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AllBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "AllBook";
            this.Size = new System.Drawing.Size(879, 492);
            this.Load += new System.EventHandler(this.AllBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dis_label;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label c_price;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private CustomControls.RJControls.MyButton myButton2;
        private CustomControls.RJControls.MyButton refresh;
        protected System.Windows.Forms.Label c_p_label;
        public System.Windows.Forms.Label name;
    }
}

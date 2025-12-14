
namespace Vidyasagar.BookStore
{
    partial class BookButton
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
            this.name = new System.Windows.Forms.Label();
            this.c_price = new System.Windows.Forms.Label();
            this.current_Price = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Font = new System.Drawing.Font("Bogart Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.name.Location = new System.Drawing.Point(8, 170);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 22);
            this.name.TabIndex = 87;
            this.name.Text = "Book";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.BookButton_Load);
            // 
            // c_price
            // 
            this.c_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c_price.AutoSize = true;
            this.c_price.Font = new System.Drawing.Font("Bogart Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.c_price.Location = new System.Drawing.Point(0, 193);
            this.c_price.Name = "c_price";
            this.c_price.Size = new System.Drawing.Size(57, 16);
            this.c_price.TabIndex = 92;
            this.c_price.Text = "Price:";
            this.c_price.Click += new System.EventHandler(this.BookButton_Load);
            // 
            // current_Price
            // 
            this.current_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.current_Price.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_Price.ForeColor = System.Drawing.Color.White;
            this.current_Price.Location = new System.Drawing.Point(51, 193);
            this.current_Price.Name = "current_Price";
            this.current_Price.Size = new System.Drawing.Size(86, 19);
            this.current_Price.TabIndex = 93;
            this.current_Price.Text = "Price:";
            this.current_Price.Click += new System.EventHandler(this.BookButton_Load);
            // 
            // disc
            // 
            this.disc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.disc.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc.ForeColor = System.Drawing.Color.Red;
            this.disc.Location = new System.Drawing.Point(62, 215);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(72, 19);
            this.disc.TabIndex = 94;
            this.disc.Text = "Price:";
            this.disc.Click += new System.EventHandler(this.BookButton_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BookButton_Load);
            // 
            // BookButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.BackgroundImage = global::Vidyasagar.Properties.Resources.Show_Info;
            this.Controls.Add(this.disc);
            this.Controls.Add(this.current_Price);
            this.Controls.Add(this.c_price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BookButton";
            this.Size = new System.Drawing.Size(137, 267);
            this.Load += new System.EventHandler(this.BookButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label c_price;
        private System.Windows.Forms.Label current_Price;
        private System.Windows.Forms.Label disc;
    }
}

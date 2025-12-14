
namespace Vidyasagar.BookStore
{
    partial class SelectedBooksButton
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
            this.buy = new FontAwesome.Sharp.IconButton();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_name = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.Transparent;
            this.buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy.FlatAppearance.BorderSize = 0;
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("BankGothic Lt BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.buy.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.buy.IconColor = System.Drawing.Color.White;
            this.buy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buy.IconSize = 30;
            this.buy.Location = new System.Drawing.Point(274, 0);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(46, 90);
            this.buy.TabIndex = 23;
            this.buy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Bogart Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.name.Location = new System.Drawing.Point(24, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(58, 22);
            this.name.TabIndex = 88;
            this.name.Text = "Book:";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bogart Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 89;
            this.label1.Text = "Quantity:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bogart Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 90;
            this.label2.Text = "Toal Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_name
            // 
            this.b_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_name.BackColor = System.Drawing.Color.Transparent;
            this.b_name.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_name.ForeColor = System.Drawing.Color.White;
            this.b_name.Location = new System.Drawing.Point(102, 14);
            this.b_name.Name = "b_name";
            this.b_name.Size = new System.Drawing.Size(166, 19);
            this.b_name.TabIndex = 94;
            this.b_name.Text = "Name";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.White;
            this.quantity.Location = new System.Drawing.Point(102, 36);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(166, 19);
            this.quantity.TabIndex = 95;
            this.quantity.Text = "Quantity";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(102, 58);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(166, 19);
            this.price.TabIndex = 96;
            this.price.Text = "Price";
            // 
            // SelectedBooksButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vidyasagar.Properties.Resources.SelectedBooks_3;
            this.Controls.Add(this.buy);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.b_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "SelectedBooksButton";
            this.Size = new System.Drawing.Size(320, 90);
            this.Load += new System.EventHandler(this.SelectedBooksButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton buy;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label b_name;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label price;
    }
}

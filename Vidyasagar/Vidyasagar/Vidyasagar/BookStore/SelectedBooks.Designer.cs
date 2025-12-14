
namespace Vidyasagar.BookStore
{
    partial class SelectedBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedBooks));
            this.BuyNow = new CustomControls.RJControls.MyButton();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyNow
            // 
            this.BuyNow.BackColor = System.Drawing.Color.Coral;
            this.BuyNow.BackgroundColor = System.Drawing.Color.Coral;
            this.BuyNow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BuyNow.BorderRadius = 10;
            this.BuyNow.BorderSize = 0;
            this.BuyNow.FlatAppearance.BorderSize = 0;
            this.BuyNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyNow.Font = new System.Drawing.Font("Bogart Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyNow.ForeColor = System.Drawing.Color.White;
            this.BuyNow.Location = new System.Drawing.Point(117, 499);
            this.BuyNow.Name = "BuyNow";
            this.BuyNow.Size = new System.Drawing.Size(150, 40);
            this.BuyNow.TabIndex = 1;
            this.BuyNow.Text = "Buy Now";
            this.BuyNow.TextColor = System.Drawing.Color.White;
            this.BuyNow.UseVisualStyleBackColor = false;
            this.BuyNow.Click += new System.EventHandler(this.BuyNow_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exitButton.IconColor = System.Drawing.Color.Red;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 25;
            this.exitButton.Location = new System.Drawing.Point(347, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitButton.TabIndex = 6;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bogart Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(86, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Amount:";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amount.Location = new System.Drawing.Point(98, 78);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(189, 24);
            this.amount.TabIndex = 8;
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 362);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // SelectedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.BuyNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectedBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectedBooks";
            this.Load += new System.EventHandler(this.SelectedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.MyButton BuyNow;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label amount;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
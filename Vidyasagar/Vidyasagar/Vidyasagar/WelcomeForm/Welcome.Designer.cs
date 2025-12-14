
namespace Vidyasagar
{
    partial class Welcome
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myButton2 = new CustomControls.RJControls.MyButton();
            this.myButton1 = new CustomControls.RJControls.MyButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bogart Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(71, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do you already have any account?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bogart Extrabold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(187, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.myButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.myButton2.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton2.BorderRadius = 10;
            this.myButton2.BorderSize = 3;
            this.myButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("Bogart Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton2.Location = new System.Drawing.Point(112, 233);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(149, 40);
            this.myButton2.TabIndex = 7;
            this.myButton2.Text = "No";
            this.myButton2.TextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click_1);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.myButton1.BorderRadius = 10;
            this.myButton1.BorderSize = 0;
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Bogart Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(303, 233);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(149, 40);
            this.myButton1.TabIndex = 6;
            this.myButton1.Text = "Yes";
            this.myButton1.TextColor = System.Drawing.Color.White;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click_1);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(564, 421);
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.MyButton myButton1;
        private CustomControls.RJControls.MyButton myButton2;
    }
}

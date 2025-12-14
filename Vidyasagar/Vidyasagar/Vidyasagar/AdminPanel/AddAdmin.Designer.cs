
namespace Vidyasagar.AdminPanel
{
    partial class AddAdmin
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
            this.admin_password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.admin_Name = new Vidyasagar.CustomDesign.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_Phone = new Vidyasagar.CustomDesign.MyTextBox();
            this.emailTextBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.passwordTextBox = new Vidyasagar.CustomDesign.MyTextBox();
            this.clear = new CustomControls.RJControls.MyButton();
            this.add = new CustomControls.RJControls.MyButton();
            this.add_Pic = new CustomControls.RJControls.MyButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(275, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add New Admin!!!";
            // 
            // admin_password
            // 
            this.admin_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_password.AutoSize = true;
            this.admin_password.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.admin_password.Location = new System.Drawing.Point(190, 335);
            this.admin_password.Name = "admin_password";
            this.admin_password.Size = new System.Drawing.Size(115, 19);
            this.admin_password.TabIndex = 81;
            this.admin_password.Text = "Password:*";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.name.Location = new System.Drawing.Point(229, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 19);
            this.name.TabIndex = 71;
            this.name.Text = "Name:*";
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.gender.Location = new System.Drawing.Point(215, 170);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(90, 19);
            this.gender.TabIndex = 72;
            this.gender.Text = "Gender:*";
            // 
            // contact
            // 
            this.contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.contact.Location = new System.Drawing.Point(207, 225);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(98, 19);
            this.contact.TabIndex = 73;
            this.contact.Text = "Contact:*";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.email.Location = new System.Drawing.Point(227, 280);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(78, 19);
            this.email.TabIndex = 74;
            this.email.Text = "Email:*";
            // 
            // dob
            // 
            this.dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.dob.Location = new System.Drawing.Point(155, 390);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(150, 19);
            this.dob.TabIndex = 75;
            this.dob.Text = "Date of Birth:*";
            // 
            // admin_Name
            // 
            this.admin_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.admin_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.admin_Name.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.admin_Name.BorderSize = 3;
            this.admin_Name.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.admin_Name.ForeColor = System.Drawing.Color.White;
            this.admin_Name.Location = new System.Drawing.Point(306, 103);
            this.admin_Name.Margin = new System.Windows.Forms.Padding(4);
            this.admin_Name.Multiline = false;
            this.admin_Name.Name = "admin_Name";
            this.admin_Name.Padding = new System.Windows.Forms.Padding(7);
            this.admin_Name.PasswordChar = false;
            this.admin_Name.Size = new System.Drawing.Size(269, 34);
            this.admin_Name.TabIndex = 90;
            this.admin_Name.Texts = "";
            this.admin_Name.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(666, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // admin_Phone
            // 
            this.admin_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.admin_Phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.admin_Phone.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.admin_Phone.BorderSize = 3;
            this.admin_Phone.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.admin_Phone.ForeColor = System.Drawing.Color.White;
            this.admin_Phone.Location = new System.Drawing.Point(306, 213);
            this.admin_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.admin_Phone.Multiline = false;
            this.admin_Phone.Name = "admin_Phone";
            this.admin_Phone.Padding = new System.Windows.Forms.Padding(7);
            this.admin_Phone.PasswordChar = false;
            this.admin_Phone.Size = new System.Drawing.Size(269, 34);
            this.admin_Phone.TabIndex = 93;
            this.admin_Phone.Texts = "";
            this.admin_Phone.UnderlinedStyle = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.emailTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.emailTextBox.BorderSize = 3;
            this.emailTextBox.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.emailTextBox.ForeColor = System.Drawing.Color.White;
            this.emailTextBox.Location = new System.Drawing.Point(306, 268);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextBox.PasswordChar = false;
            this.emailTextBox.Size = new System.Drawing.Size(269, 34);
            this.emailTextBox.TabIndex = 94;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.passwordTextBox.BorderSize = 3;
            this.passwordTextBox.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(306, 323);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.Size = new System.Drawing.Size(269, 34);
            this.passwordTextBox.TabIndex = 95;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
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
            this.clear.Location = new System.Drawing.Point(247, 437);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(163, 40);
            this.clear.TabIndex = 97;
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
            this.add.Location = new System.Drawing.Point(471, 437);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(163, 40);
            this.add.TabIndex = 96;
            this.add.Text = "Add";
            this.add.TextColor = System.Drawing.Color.White;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.add_Pic.Location = new System.Drawing.Point(643, 345);
            this.add_Pic.Name = "add_Pic";
            this.add_Pic.Size = new System.Drawing.Size(166, 46);
            this.add_Pic.TabIndex = 98;
            this.add_Pic.Text = "Add Image";
            this.add_Pic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.add_Pic.UseVisualStyleBackColor = false;
            this.add_Pic.Click += new System.EventHandler(this.add_Pic_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.radioButton1.Location = new System.Drawing.Point(313, 169);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 20);
            this.radioButton1.TabIndex = 99;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bogart", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.radioButton2.Location = new System.Drawing.Point(389, 169);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 100;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Dutch801 Rm BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Dutch801 Rm BT", 9.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 388);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 23);
            this.dateTimePicker1.TabIndex = 101;
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.add_Pic);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.admin_Phone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_Name);
            this.Controls.Add(this.admin_password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label1);
            this.Name = "AddAdmin";
            this.Size = new System.Drawing.Size(881, 548);
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label admin_password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label dob;
        private CustomDesign.MyTextBox admin_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomDesign.MyTextBox admin_Phone;
        private CustomDesign.MyTextBox emailTextBox;
        private CustomDesign.MyTextBox passwordTextBox;
        private CustomControls.RJControls.MyButton clear;
        private CustomControls.RJControls.MyButton add;
        private CustomControls.RJControls.MyButton add_Pic;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

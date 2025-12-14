
namespace Vidyasagar.AdminPanel
{
    partial class AdminInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.status_comboBox1 = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.Label();
            this.admin_password = new System.Windows.Forms.Label();
            this.bath_Date = new System.Windows.Forms.Label();
            this.update = new CustomControls.RJControls.MyButton();
            this.admin_Email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_Phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.admin_Gender = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.admin_Name = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.myButton1 = new CustomControls.RJControls.MyButton();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.infoPanel.Controls.Add(this.status_comboBox1);
            this.infoPanel.Controls.Add(this.password);
            this.infoPanel.Controls.Add(this.admin_password);
            this.infoPanel.Controls.Add(this.bath_Date);
            this.infoPanel.Controls.Add(this.update);
            this.infoPanel.Controls.Add(this.admin_Email);
            this.infoPanel.Controls.Add(this.pictureBox1);
            this.infoPanel.Controls.Add(this.admin_Phone);
            this.infoPanel.Controls.Add(this.name);
            this.infoPanel.Controls.Add(this.admin_Gender);
            this.infoPanel.Controls.Add(this.gender);
            this.infoPanel.Controls.Add(this.admin_Name);
            this.infoPanel.Controls.Add(this.contact);
            this.infoPanel.Controls.Add(this.status);
            this.infoPanel.Controls.Add(this.email);
            this.infoPanel.Controls.Add(this.dob);
            this.infoPanel.Location = new System.Drawing.Point(18, 317);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(844, 213);
            this.infoPanel.TabIndex = 17;
            // 
            // status_comboBox1
            // 
            this.status_comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status_comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.status_comboBox1.Font = new System.Drawing.Font("Bogart Trial", 9.749999F);
            this.status_comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.status_comboBox1.FormattingEnabled = true;
            this.status_comboBox1.Items.AddRange(new object[] {
            "Activated",
            "Banned",
            "Leave",
            "Owner"});
            this.status_comboBox1.Location = new System.Drawing.Point(619, 110);
            this.status_comboBox1.Name = "status_comboBox1";
            this.status_comboBox1.Size = new System.Drawing.Size(164, 28);
            this.status_comboBox1.TabIndex = 71;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(619, 37);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(95, 19);
            this.password.TabIndex = 70;
            this.password.Text = "Password";
            // 
            // admin_password
            // 
            this.admin_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_password.AutoSize = true;
            this.admin_password.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.admin_password.Location = new System.Drawing.Point(508, 37);
            this.admin_password.Name = "admin_password";
            this.admin_password.Size = new System.Drawing.Size(108, 19);
            this.admin_password.TabIndex = 69;
            this.admin_password.Text = "Password:";
            // 
            // bath_Date
            // 
            this.bath_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bath_Date.AutoSize = true;
            this.bath_Date.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.bath_Date.ForeColor = System.Drawing.Color.White;
            this.bath_Date.Location = new System.Drawing.Point(619, 76);
            this.bath_Date.Name = "bath_Date";
            this.bath_Date.Size = new System.Drawing.Size(99, 19);
            this.bath_Date.TabIndex = 67;
            this.bath_Date.Text = "Birth Date";
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.update.BorderRadius = 10;
            this.update.BorderSize = 0;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Bogart Trial", 15.75F);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(671, 164);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(163, 40);
            this.update.TabIndex = 18;
            this.update.Text = "Update";
            this.update.TextColor = System.Drawing.Color.White;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // admin_Email
            // 
            this.admin_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_Email.AutoSize = true;
            this.admin_Email.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.admin_Email.ForeColor = System.Drawing.Color.White;
            this.admin_Email.Location = new System.Drawing.Point(235, 154);
            this.admin_Email.Name = "admin_Email";
            this.admin_Email.Size = new System.Drawing.Size(130, 19);
            this.admin_Email.TabIndex = 66;
            this.admin_Email.Text = "***@email.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(18, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_Phone
            // 
            this.admin_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_Phone.AutoSize = true;
            this.admin_Phone.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.admin_Phone.ForeColor = System.Drawing.Color.White;
            this.admin_Phone.Location = new System.Drawing.Point(235, 115);
            this.admin_Phone.Name = "admin_Phone";
            this.admin_Phone.Size = new System.Drawing.Size(91, 19);
            this.admin_Phone.TabIndex = 65;
            this.admin_Phone.Text = "01*********";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.name.Location = new System.Drawing.Point(166, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 19);
            this.name.TabIndex = 57;
            this.name.Text = "Name:";
            // 
            // admin_Gender
            // 
            this.admin_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_Gender.AutoSize = true;
            this.admin_Gender.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.admin_Gender.ForeColor = System.Drawing.Color.White;
            this.admin_Gender.Location = new System.Drawing.Point(235, 76);
            this.admin_Gender.Name = "admin_Gender";
            this.admin_Gender.Size = new System.Drawing.Size(137, 19);
            this.admin_Gender.TabIndex = 64;
            this.admin_Gender.Text = "Admin Gender";
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.gender.Location = new System.Drawing.Point(152, 76);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(83, 19);
            this.gender.TabIndex = 58;
            this.gender.Text = "Gender:";
            // 
            // admin_Name
            // 
            this.admin_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_Name.AutoSize = true;
            this.admin_Name.Font = new System.Drawing.Font("Bogart", 14.25F);
            this.admin_Name.ForeColor = System.Drawing.Color.White;
            this.admin_Name.Location = new System.Drawing.Point(235, 37);
            this.admin_Name.Name = "admin_Name";
            this.admin_Name.Size = new System.Drawing.Size(124, 19);
            this.admin_Name.TabIndex = 63;
            this.admin_Name.Text = "Admin Name";
            // 
            // contact
            // 
            this.contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.contact.Location = new System.Drawing.Point(144, 115);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(91, 19);
            this.contact.TabIndex = 59;
            this.contact.Text = "Contact:";
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.status.Location = new System.Drawing.Point(450, 115);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(166, 19);
            this.status.TabIndex = 62;
            this.status.Text = "Account Status:";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.email.Location = new System.Drawing.Point(164, 154);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(71, 19);
            this.email.TabIndex = 60;
            this.email.Text = "Email:";
            // 
            // dob
            // 
            this.dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Bogart Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.dob.Location = new System.Drawing.Point(473, 76);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(143, 19);
            this.dob.TabIndex = 61;
            this.dob.Text = "Date of Birth:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bogart Bold", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(316, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Admin Info!!!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bogart Bold", 9.749999F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(170)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bogart", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(18, 66);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(844, 242);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.textBox1.Font = new System.Drawing.Font("Bogart", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 75;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(194, 35);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.TabIndex = 74;
            this.iconPictureBox1.TabStop = false;
            // 
            // myButton1
            // 
            this.myButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.myButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(178)))));
            this.myButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.myButton1.BorderRadius = 10;
            this.myButton1.BorderSize = 0;
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Bogart Trial", 15.75F);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(659, 19);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(163, 40);
            this.myButton1.TabIndex = 53;
            this.myButton1.Text = "Refresh";
            this.myButton1.TextColor = System.Drawing.Color.White;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AdminInfo";
            this.Size = new System.Drawing.Size(881, 548);
            this.Load += new System.EventHandler(this.AdminInfo_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.MyButton update;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.MyButton myButton1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label admin_password;
        private System.Windows.Forms.Label bath_Date;
        private System.Windows.Forms.Label admin_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label admin_Phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label admin_Gender;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label admin_Name;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.ComboBox status_comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Panel infoPanel;
    }
}

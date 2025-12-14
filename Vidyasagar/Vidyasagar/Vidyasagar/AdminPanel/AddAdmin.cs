using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Vidyasagar.AdminPanel
{
    public partial class AddAdmin : UserControl
    {
        string image = null;
        string admin_gender;

        //SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");

        public AddAdmin()
        {
            InitializeComponent();
        }

        private void add_Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                image = file.FileName.ToString();
                pictureBox1.ImageLocation = image;
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            admin_gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            admin_gender = "Female";
        }

        private void add_Click(object sender, EventArgs e)
        {
            string a_Name = admin_Name.Texts;
            string a_Phone = admin_Phone.Texts;
            string a_email = emailTextBox.Texts;
            string a_password = passwordTextBox.Texts;

            if (CheckEmali() == true && a_Name.Length > 0 && admin_gender != null && a_Phone.Length > 0 && a_email.Length > 0 && dateTimePicker1.Text != null && a_password.Length > 0)
            {
                if(new EntityClass.Admin().Add_New_Admin(image, admin_Name.Texts, admin_gender, admin_Phone.Texts, emailTextBox.Texts, dateTimePicker1.Value.ToString(), passwordTextBox.Texts))
                {
                    MessageBox.Show("Admin info update");
                    Clear();
                }
                else MessageBox.Show("Error!!!");
            }
            
            else if (CheckEmali() == false) MessageBox.Show("This email is already used!!!");
            else MessageBox.Show("Fill all required info(*)");
        }

        void Clear()
        {
            admin_Name.Texts = null;
            admin_gender = null;
            admin_Phone.Texts = null;
            emailTextBox.Texts = null;
            dateTimePicker1.Text = null;
            image = null;
            passwordTextBox.Texts = null;
            pictureBox1.Image = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        bool CheckEmali()
        {
            return new EntityClass.Admin().Check_Log_Email(emailTextBox.Texts);
        }
    }
}

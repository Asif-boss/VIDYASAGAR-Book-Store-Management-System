using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Vidyasagar.AdminPanel
{
    public partial class UserInfo : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //public EntityClass.Admin admin_Person;

        public UserInfo()
        {
            InitializeComponent();
            infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, infoPanel.Width, infoPanel.Height, 30, 30));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridView1.Width, dataGridView1.Height, 20, 20));

            load_Table();
        }

        public void load_Table()
        {
            DataTable dt = new EntityClass.Admin().All_Customer_Data();
            dataGridView1.DataSource = dt;
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if(new EntityClass.Admin().update_log_Info(status_comboBox1.Text, customer_Email.Text))
            {
                load_Table();
                MessageBox.Show("Updated Successfully!!!");
            }
            else
            {
                MessageBox.Show("Can't be Updated!!!");
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            load_Table();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            customer_Name.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            Customer_Gender.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            customer_Phone.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            customer_Email.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            bath_Date.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
            status_comboBox1.Text = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
            
            try
            {
                byte[] imgdata = (byte[])(dataGridView1.Rows[row_index].Cells[5].Value);
                var mStream = new MemoryStream(imgdata);
                pictureBox1.Image = Image.FromStream(mStream);
            }
            catch (Exception excep)
            {
                pictureBox1.Image = null;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new EntityClass.Admin().Customer_Info_Search(textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text);
            dataGridView1.DataSource = dt;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

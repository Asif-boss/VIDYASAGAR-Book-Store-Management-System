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

namespace Vidyasagar.AdminPanel
{
    public partial class AdminInfo : UserControl
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

        //SqlConnection con = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Vidyasagar;Integrated Security=True");
        string image = null;

        public AdminInfo()
        {
            InitializeComponent();
            infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, infoPanel.Width, infoPanel.Height, 30, 30));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridView1.Width, dataGridView1.Height, 20, 20));

            load_Table();
        }

        public void load_Table()
        {
            DataTable dt = new EntityClass.Admin().all_Admin_Info();
            dataGridView1.DataSource = dt;
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {

        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

            load_Table();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            image = null;
            int row_index = e.RowIndex;

            admin_Name.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            admin_Gender.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            admin_Phone.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            admin_Email.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            bath_Date.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
            status_comboBox1.Text = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
            password.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                image = file.FileName.ToString();
                pictureBox1.ImageLocation = image;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            DataTable dt = new EntityClass.Admin().Admin_Info_Search(textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text);
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                if (new EntityClass.Admin().update_Admin_Info_With_Pic(image, admin_Email.Text)) MessageBox.Show("Updated Pic Successfully!!!");
                else MessageBox.Show("Can't be update pic!!!");
            }

            if (new EntityClass.Admin().update_log_Info(status_comboBox1.Text, admin_Email.Text))
            {
                load_Table();
                MessageBox.Show("Updated Successfully!!!");
            }
            else
            {
                MessageBox.Show("Can't be Updated!!!");
            }

            image = null;
            textBox1.Text = null;
            load_Table();
        }
    }
}

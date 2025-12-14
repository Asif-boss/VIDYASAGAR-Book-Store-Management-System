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
    public partial class BookInfo : UserControl
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

        string image = null;

        public BookInfo()
        {
            InitializeComponent();
            infoPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, infoPanel.Width, infoPanel.Height, 30, 30));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridView1.Width, dataGridView1.Height, 20, 20));

            load_Table();
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            load_Table();
            textBox1.Text = null;
            clear_Data();
        }

        private void load_Table()
        {
            
            DataTable dt = new EntityClass.Admin().load_Book_Info();            
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            book_Name.Texts = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            author_Name.Texts = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
            main_Price.Texts = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            dicount_percentage.Texts = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            stock.Texts = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            total_Sell.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();

            id_label.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();

            double m_price = (double) dataGridView1.Rows[row_index].Cells[3].Value;
            double d_price = (double)dataGridView1.Rows[row_index].Cells[4].Value;

            C_Price.Text = (m_price - (m_price * d_price/100)).ToString();

            try
            {
                byte[] imgdata = (byte[])(dataGridView1.Rows[row_index].Cells[7].Value);
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
            DataTable dt = new EntityClass.Admin().Search_Book_Info(textBox1.Text);            
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            string b_name = book_Name.Texts;
            string a_name = author_Name.Texts;
            string b_price = main_Price.Texts;
            string b_discount = dicount_percentage.Texts;
            string b_stock = stock.Texts;
            string p_date = dateTimePicker1.Value.ToString();
            string b_id = id_label.Text;

            if(image == null && b_id == null) MessageBox.Show("Select one!!!");
            else if(new EntityClass.Admin().updat_Book_Info(image, b_name, a_name, b_price, b_discount, b_stock, p_date, b_id))
            {
                MessageBox.Show("Updated Successfully!!!");
                load_Table();
                clear_Data();
            }
            else MessageBox.Show("Can't be update book info!!!");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(new EntityClass.Admin().delete_Book(id_label.Text))
            {
                MessageBox.Show("Book has been deleted!!!");
                load_Table();
                clear_Data();
            }
            else MessageBox.Show("Book has not been deleted!!!");
                      
        }

        private void clear_Data()
        {
            image = null;
            book_Name.Texts = null;
            author_Name.Texts = null;
            dateTimePicker1.Text = null;
            main_Price.Texts = null;
            dicount_percentage.Texts = null;
            stock.Texts = null;
            C_Price.Text = null;
            total_Sell.Text = null;
            pictureBox1.Image = null;
            id_label.Text = "ID";
        }
    }
}

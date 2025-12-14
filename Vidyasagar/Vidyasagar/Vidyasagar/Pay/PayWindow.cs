using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidyasagar.Pay
{
    public partial class PayWindow : Form
    {
        public PayWindow()
        {
            InitializeComponent();
        }
        

        public delegate void Pay(Object sender);
        public event Pay pay;

        private void label1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "123" && textBox2.Text == "123")
            {
                pay(this);
                textBox1.Text = null;
                textBox2.Text = null;
            }
            else MessageBox.Show("Give all correct data!!!");            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Text = null;
            textBox2.Text = null;
        }

        public void addPrice(double taka)
        {
            amount.Text = taka.ToString() + " BDT";
        }
    }
}

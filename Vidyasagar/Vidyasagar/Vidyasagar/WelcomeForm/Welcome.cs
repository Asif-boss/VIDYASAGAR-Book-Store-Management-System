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

namespace Vidyasagar
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        public delegate void RemoveAndLogin(Object sender);
        public event RemoveAndLogin RemoveAndLog;

        private void myButton1_Click_1(object sender, EventArgs e)
        {
            RemoveAndLog(this);
        }

        public delegate void RemoveAndSignUp(Object sender);
        public event RemoveAndLogin RemoveAndSign;

        private void myButton2_Click_1(object sender, EventArgs e)
        {
            RemoveAndSign(this);
        }
    }
}

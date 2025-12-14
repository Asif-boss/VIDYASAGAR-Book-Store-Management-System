using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidyasagar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Form1 welcomeFrom = new Form1();
            Application.Run(welcomeFrom);
            

            //Application.Run(new Form1());
            //Application.Run(new BookStore.BookStore());
            //Application.Run(new AdminPanel.AdminPanel());
            //Application.Run(new Pay.PayWindow());
        }
    }
}

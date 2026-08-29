using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CashierWindowQueueForm CWQF = new CashierWindowQueueForm();
            CWQF.Show();
            Form3 form3 = new Form3();
            form3.Show();
            Application.Run(new QueuingForm());
        }
    }
}

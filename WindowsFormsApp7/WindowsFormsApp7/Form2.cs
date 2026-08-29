using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using static WindowsFormsApp7.QueuingForm;

namespace WindowsFormsApp7
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_tick;
            timer.Start();
        }
        
        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listView1.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listView1.Items.Add(obj.ToString());
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp7.QueuingForm;

namespace WindowsFormsApp7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += servetime;
            timer.Start();
        }
        private void servetime(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                string currentNumber = CashierClass.CashierQueue.Peek();
                string dequeueNumber = CashierClass.CashierQueue.Dequeue();
                label2.Text = currentNumber;
            }
            else
            {
                label2.Text = "P - 00000";
            }
        }
    }
}

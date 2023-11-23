using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] callLengths = new int[] { 300, 1200, 666, 420 };
            double totalamount = 0;

            foreach (int callLength in callLengths)
            {
                double amount;

                if (callLength <= 500)
                {
                    amount = callLength * 0.01;
                }
                else if (callLength <= 800)
                {
                    amount = (callLength - 500) * 0.008 + 5; // 500 * 0.01
                }
                else
                {
                    amount = (callLength - 800) * 0.005 + 7.4; // 500 * 0.01 + 300 * 0.008;
                }
                totalamount += amount;
                //Console.WriteLine(amount);
            }

            Console.WriteLine("Total to pay: " + totalamount);
        }
    }
}

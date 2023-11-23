using Microsoft.VisualBasic;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double income = double.Parse(Interaction.InputBox("Please type in the income"));
            double tax;

            if (income <= 18200)
            {
                tax = 0;
            }
            else if (income <= 37000)
            {
                tax = (income - 18200) * 0.19;
            }
            else if (income <= 90000)
            {
                tax = (income - 37000) * 0.235 + 3572; // (37000 - 18200) * 0.19
            }
            else if (income <= 180000)
            {
                tax = (income - 90000) * 0.37 + 16027;
                // (37000 - 18200) * 0.19 + (90000-37000) * 0.235
            }
            else
            {
                tax = (income - 180000) * 0.45 + 49327;
                // (37000 - 18200) * 0.19 + (90000-37000) * 0.235 + (180.000 - 90.000) * 0.37
            }
            MessageBox.Show("You have to pay " + tax.ToString() + " in taxes");
        }
    }
}

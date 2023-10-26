using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void labelNr2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double a; double b; double result;

            bool isParseableFirst = Double.TryParse(textBoxNr1.Text, out a);

            if (!isParseableFirst)
            {
                MessageBox.Show("Introduceti un numar in text box 1");
                textBoxNr1.Text = "";
                return;
            }

            bool isParseableSecond = Double.TryParse(textBoxNr2.Text, out b);

            if (!isParseableSecond)
            {
                MessageBox.Show("Introduceti un numar in text box 2");
                textBoxNr2.Text = "";
                return;
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    MessageBox.Show("Infinitate de solutii");
                } else
                {
                    MessageBox.Show("Nu exista solutii");
                }
            } else
            {
                result = -b / a;
                MessageBox.Show("Solutia = " + result);
            }

        }
    }
}

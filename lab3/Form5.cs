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
    public partial class Form5 : Form
    {
        // Preia din inputuri doua valori numerice pentru coeficientii 
        // ecuatiei de gradul I

        // Rezolva ecutia la actionarea butonului

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a; Double b; Double solution;

            try
            {
                a = Double.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("First input should be a double number");
                return;
            }

            try
            {
                b = Double.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Second input should be a double number");
                return;
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    MessageBox.Show("Infinity");
                } else
                {
                    MessageBox.Show("No solutions");
                }
            } else
            {
                solution = -b / a;
                MessageBox.Show(solution.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

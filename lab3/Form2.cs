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
    public partial class Form2 : Form
    {
        // Preia din inputuri trei valori numerice pentru coeficientii 
        // ecuatiei de gradul II

        // Rezolva ecutia la actionarea butonului

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a; Double b; Double c; Double d;  Double x1; Double x2;

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

            try
            {
                c = Double.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Third input should be a double number");
                return;
            }

            //d = b * b - 4 * a * c;
            d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(d);
            if (d == 0)
            {
                x1 = x2 = (-b + Math.Sqrt(d)) / 2 * a;
                MessageBox.Show("There is one solution: " + x1.ToString());
            } else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                MessageBox.Show("There solutions are: " + x1.ToString() + " and " + x2.ToString());
            } else
            {
                MessageBox.Show("There are no real solutions");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double first; Double second;
            bool isParsableFirst = Double.TryParse(textboxNumber1.Text, out first);

            if (!isParsableFirst)
            {
                MessageBox.Show("First number should be a double!");
                return;
            }

            bool isParsableSecond = Double.TryParse(textboxNumber2.Text, out second);

            if (!isParsableSecond)
            {
                MessageBox.Show("Second number should be a double!");
                return;
            }


            MessageBox.Show((first + second).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double first; Double second;

            try {
                first = Double.Parse(textboxNumber1.Text);
            } catch (Exception ex) {
                MessageBox.Show("First input should be a double number");
                return;
            }

            try
            {
                second = Double.Parse(textboxNumber2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Second input should be a double number");
                return;
            }

            MessageBox.Show((first - second).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int first = Int32.Parse(textboxNumber1.Text);
            int second = Int32.Parse(textboxNumber2.Text);


            MessageBox.Show((first / second).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte first = byte.Parse(textboxNumber1.Text);
            byte second = byte.Parse(textboxNumber2.Text);


            MessageBox.Show((first *  second).ToString());
        }

        private void textboxNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

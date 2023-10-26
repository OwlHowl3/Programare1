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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            double firstNumber = Double.Parse(textBoxNr1.Text);
            double secondNumber = Double.Parse(textBoxNr2.Text);

            double result = firstNumber + secondNumber;

            MessageBox.Show(
                "Numarul 1: " + firstNumber + "; Numarul 2: " +
                secondNumber + "; Rezultat adunare: " + result
            );
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void buttonDifference_Click(object sender, EventArgs e)
        {
            double firstNumber; double secondNumber; double result;

            try
            {
                firstNumber = Double.Parse(textBoxNr1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti un numar valid in textbox 1!");
                textBoxNr1.Text = "";
                return;
            }

            try
            {
                secondNumber = Double.Parse(textBoxNr2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti un numar valid in texbox 2!");
                textBoxNr2.Text = "";
                return;
            }

            result = firstNumber - secondNumber;
            MessageBox.Show(
                "Numarul 1: " + firstNumber + "; Numarul 2: " +
                secondNumber + "; Rezultat scadere: " + result
            );
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            double firstNumber; double secondNumber; double result;

            bool isParseableFirst = Double.TryParse(textBoxNr1.Text, out firstNumber);

            if (!isParseableFirst)
            {
                MessageBox.Show("Introduceti un numar in text box 1");
                textBoxNr1.Text = "";
                return;
            }

            bool isParseableSecond = Double.TryParse(textBoxNr2.Text, out secondNumber);

            if (!isParseableSecond)
            {
                MessageBox.Show("Introduceti un numar in text box 2");
                textBoxNr2.Text = "";
                return;
            }

            result = firstNumber * secondNumber;
            MessageBox.Show(result.ToString());
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            double firstNumber; double secondNumber; double result;

            bool isParseableFirst = Double.TryParse(textBoxNr1.Text, out firstNumber);

            if (!isParseableFirst)
            {
                MessageBox.Show("Introduceti un numar in text box 1");
                textBoxNr1.Text = "";
                return;
            }

            bool isParseableSecond = Double.TryParse(textBoxNr2.Text, out secondNumber);

            if (!isParseableSecond)
            {
                MessageBox.Show("Introduceti un numar in text box 2");
                textBoxNr2.Text = "";
                return;
            }

            result = firstNumber / secondNumber;
            MessageBox.Show(result.ToString());
        }
    }
}

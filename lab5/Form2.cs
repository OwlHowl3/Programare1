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

namespace lab5
{
    // Preluaţi de la utilizator un număr n.

    // Preluaţi apoi n valori numerice într-un vector.

    // Preluaţi de la utilizator 2 valori: a şi b.

    // Generaţi un alt vector care să conţină valorile care
    // nu sunt între a şi b.Afişaţi apoi numărul acestor valori.
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int n;
            do
            {
                string inputText = Interaction.InputBox("Type in the number of values", "Input Required", "0");

                if (int.TryParse(inputText, out n))
                {
                    // Valid integer input
                    break; // Exit the loop
                }
            } while (true);

            int[] values = new int[n];

            for (int i = 0; i < n; i++)
            {
                int value;
                do
                {
                    string inputText = Interaction.InputBox("Please give me number " + (i + 1), "Input Required", "0");

                    if (int.TryParse(inputText, out value))
                    {
                        // Valid integer input
                        break; // Exit the loop
                    }
                } while (true);
                values[i] = value;
            }

            int min; int max;
            do
            {
                string inputText = Interaction.InputBox("Min Value?", "Input Required", "0");

                if (int.TryParse(inputText, out min))
                {
                    // Valid integer input
                    break; // Exit the loop
                }
            } while (true);
            do
            {
                string inputText = Interaction.InputBox("Max Value?", "Input Required", "0");

                if (int.TryParse(inputText, out max))
                {
                    // Valid integer input
                    break; // Exit the loop
                }
            } while (true);

            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min || values[i] > max)
                {
                    count++;
                }
            }

            MessageBox.Show("Total values not in range: " + count.ToString());
        }
    }
}


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

namespace lab4
{
    public partial class Form2 : Form
    {
        // Preluaţi de la utilizator un număr n.
        
        // Preluaţi apoi n valori numerice într-un vector.

        // Preluaţi de la utilizator 2 valori: a şi b.

        // Calculaţi media valorilor din vector cuprinse între valorile a şi b
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int n;

            n = int.Parse(
                Interaction.InputBox("Type in the number of values")
            );


            int[] values = new int[n];

            for(int i = 0; i < n; i++)
            {
                int value = int.Parse(
                    Interaction.InputBox("Please give me number " + (i+1))
                );
                values[i] = value;
            }

            int min; int max;
            min = int.Parse(
                Interaction.InputBox("Min value?")
            );
            max = int.Parse(
                Interaction.InputBox("Max value?")
            );
            int total = 0; int count = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= min && values[i] <= max)
                {
                    total += values[i];
                    count++;
                }
            }

            double mean = (double)total / (double)count;
            MessageBox.Show("Mean value between min and max is " + mean);

        }
    }
}

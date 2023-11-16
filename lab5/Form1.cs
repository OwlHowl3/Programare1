using Microsoft.VisualBasic;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        //Preluaţi de la utilizator un număr n.

        //Preluaţi apoi n valori numerice într-un vector.

        //Preluaţi de la utilizator valoarea a.

        //Afişaţi numărul de valori din vector mai mici decât a şi apoi afişaţi respectivele valori.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n;

            //n = int.Parse(
            //    Interaction.InputBox("Type in the number of values")
            //);

            do
            {
                string inputText = Interaction.InputBox(
                    "Enter an integer:", 
                    "Input Required", 
                    "0"
                );

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
                    string inputText = Interaction.InputBox(
                        "Please give me number" + (i + 1),
                        "Input Required", 
                        "0"
                    );

                    if (int.TryParse(inputText, out value))
                    {
                        // Valid integer input
                        break; // Exit the loop
                    }
                } while (true);
                values[i] = value;
            }

            int a;
            do
            {
                string inputText = Interaction.InputBox(
                    "Number a?",
                    "Input Required", 
                    "0"
                );

                if (int.TryParse(inputText, out a))
                {
                    // Valid integer input
                    break; // Exit the loop
                }
            } while (true);

            ArrayList valuesLessThanA = new ArrayList();
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < a)
                {
                    valuesLessThanA.Add(values[i]);
                }
            }
            MessageBox.Show(
                "Total values less than " + a.ToString() +
                ": " + valuesLessThanA.Count.ToString()
            );
            string itemsString = "";
            for (int i = 0; i < valuesLessThanA.Count; i++)
            {
                itemsString += valuesLessThanA[i].ToString();
                if (i != valuesLessThanA.Count - 1)
                {
                    itemsString += ",";
                }
            }
            MessageBox.Show("Values: " + itemsString);
        }
    }
}

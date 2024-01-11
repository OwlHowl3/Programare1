using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab11
{
    public partial class Form5 : Form
    {
        // La click pe buton - preia valoarea din numeric up down,
        // compara valoarea cu elementele dintr-o lista,
        // afiseaza elementele mai mici decat valoarea preluata.

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numericUpDownValue = numericUpDown1.Value;

            MessageBox.Show("Trackbar value: " + numericUpDownValue.ToString());

            int[] values = new int[] { 4, 8, 15, 16, 32, 43, 68, 88, 96 };

            string valuesLessThanInput = "";
            foreach (int val in values)
            {
                if (val < numericUpDownValue)
                {
                    valuesLessThanInput += val.ToString() + ",";
                }
            }
            valuesLessThanInput = valuesLessThanInput.TrimEnd(',', ' ');

            MessageBox.Show(
                "Values less than " + 
                numericUpDownValue.ToString() + 
                ": " + valuesLessThanInput
            );
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

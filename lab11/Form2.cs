using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form2 : Form
    {
        // La click pe buton - preia valoarea din trackbar,
        // compara valoarea cu elementele dintr-o lista,
        // afiseaza elementele mai mici decat valoarea preluata.

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trackbarValue = trackBar1.Value;

            MessageBox.Show("Trackbar value: " + trackbarValue.ToString());

            int[] values = new int[] { 4, 8, 15, 16, 32, 43, 68, 88, 96};

            string valuesLessThanInput = "";

            foreach(int val in values)
            {
                if (val < trackbarValue) {
                    valuesLessThanInput += val.ToString() + ",";
                }
            }

            valuesLessThanInput = valuesLessThanInput.TrimEnd(',', ' ');

            MessageBox.Show(
                "Values less than " +
                trackbarValue.ToString() + ": " +
                valuesLessThanInput
            );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

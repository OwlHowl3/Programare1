using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        // Defineste meniul si evenimentele de deschidere a formularelor noi
        // la evenimentul de click pe fiecare item din submeniu

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void form2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void form3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

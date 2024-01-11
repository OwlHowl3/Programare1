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
    public partial class Form1 : Form
    {
        // Defineste meniul si evenimentele de deschidere a formularelor noi
        // la evenimentul de click pe fiecare item din submeniu
        public Form1()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void form6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void form7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void form8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

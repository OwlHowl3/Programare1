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
    public partial class Form8 : Form
    {
        // Populeaza combobox la crearea formularului

        // Populeaza listbox la crearea formularului

        // La actionarea butonului transfera item-ul din combobox
        // daca acesta nu este in listbox. Altel arata mesaj de atentionare.

        public Form8()
        {
            InitializeComponent();

            comboBox1.Items.Add("Volvo");
            comboBox1.Items.Add("Mercedes");
            comboBox1.Items.Add("BMW");
            comboBox1.Items.Add("Porsche");
            comboBox1.Items.Add("Ferarri");
            comboBox1.Items.Add("Renault");

            listBox1.Items.Add("Volvo");
            listBox1.Items.Add("Volkswagen");
            listBox1.Items.Add("Audi");
            listBox1.Items.Add("Renault");
            listBox1.Items.Add("Dacia");
            listBox1.Items.Add("Toyota");
            listBox1.Items.Add("Mazda");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comboboxSelectedItem = comboBox1.SelectedItem.ToString();

            if (!listBox1.Items.Contains(comboboxSelectedItem))
            {
                listBox1.Items.Add(comboboxSelectedItem);
            } else
            {
                MessageBox.Show("Item already exists");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}

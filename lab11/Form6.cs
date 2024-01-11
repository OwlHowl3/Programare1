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
    public partial class Form6 : Form
    {
        // Populeaza listbox 1 la incarcarea formularului

        // Populeaza listbox 2 la incarcarea formularului

        // La click pe buton - afiseaza siruri de caractere cu 
        // itemi comuni, itemi doar in listbox 1, itemi doar in listbox2 

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Snickers");
            listBox1.Items.Add("Mars");
            listBox1.Items.Add("Twix");
            listBox1.Items.Add("Poiana");
            listBox1.Items.Add("Kinder");
            listBox1.Items.Add("Africana");

            listBox2.Items.Add("Twix");
            listBox2.Items.Add("Ferero Rosher");
            listBox2.Items.Add("Milka");
            listBox2.Items.Add("Raffaelo");
            listBox2.Items.Add("Lindt");
            listBox2.Items.Add("Kinder");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commonItems = "";
            string itemsOnly1 = "";
            string itemsOnly2 = "";


            foreach (object item in listBox1.Items)
            {
                if (listBox2.Items.Contains(item.ToString()))
                {
                    commonItems += item.ToString() + ",";
                }
            }
            commonItems = commonItems.TrimEnd(',', ' ');


            foreach (object item in listBox1.Items)
            {
                if (!listBox2.Items.Contains(item.ToString()))
                {
                    itemsOnly1 += item.ToString() + ",";
                }
            }
            itemsOnly1 = itemsOnly1.TrimEnd(',', ' ');


            foreach (object item in listBox2.Items)
            {
                if (!listBox1.Items.Contains(item.ToString()))
                {
                    itemsOnly2 += item.ToString() + ",";
                }
            }
            itemsOnly2 = itemsOnly2.TrimEnd(',', ' ');


            MessageBox.Show(
                "Common items: " + commonItems
                + "\nOnly in 1: " + itemsOnly1
                + "\nOnly in 2: " + itemsOnly2
            );
        }
    }
}

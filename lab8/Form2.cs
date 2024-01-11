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

namespace lab8
{
    public partial class Form2 : Form
    {
        // Adauga itemi in listbox la crearea formularului

        // La click pe primul buton (show items) - creeaza un string cu toti 
        // itemii si afiseeaza-l

        // La click pe al doilea buton (add item) - adauga item in listbox 
        // daca aceste nu exista, altfel afiseaza mesaj de atentionare

        // La click pe al treilea buton (delete items) - sterge toti itemii
        // selectati din listbox.

        public Form2()
        {
            InitializeComponent();

            // Add items to the listbox
            listBox1.Items.Add("Iasi");
            listBox1.Items.Add("Suceava");
            listBox1.Items.Add("Bacau");
            listBox1.Items.Add("Vaslui");
            listBox1.Items.Add("Galati");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display selected items in a message box
            if (listBox1.SelectedItems.Count > 0)
            {
                string selectedItems = "";
                
                foreach (object city in listBox1.SelectedItems)
                {
                    selectedItems += city.ToString() + ",";
                }
                selectedItems = selectedItems.TrimEnd(',', ' ');
                MessageBox.Show(selectedItems);
            }
            else
            {
                MessageBox.Show("No items are selected!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add new item to the listbox
            string newItem = Interaction.InputBox(
                "Enter a new item:", "Add Item"
            );

            if (
                !string.IsNullOrEmpty(newItem) && 
                !listBox1.Items.Contains(newItem)
            )
            {
                listBox1.Items.Add(newItem);
            }
            else
            {
                MessageBox.Show("Item already exists or no item was entered!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete selected items from the listbox
            if (listBox1.SelectedItems.Count > 0)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("No items are selected!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace lab9
{
    public partial class Form3 : Form
    {
        // Creeaza o lista de todouri de  tip string la nivelul clasei
        // La incarcarea formularului adauga elementele din lista in listbox

        // La click pe primul buton (add todo) - adauga item in listbox 
        // si in lista de todo-uri

        // La click pe al doilea buton (delete todos) - sterge toti itemii
        // selectati din listbox. Daca nu a fost selectat nimic - 
        // afiseaza mesaj de atentionare.


        private List<string> toDoList = new List<string>()
        {
            "Wake up",
            "Eat",
            "Go to uni"
        };

        public Form3()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Delete the selected item from the to-do list
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Add a new item to the to-do list
            string newItem = Interaction.InputBox("Enter a new item:", "Add Item");
            if (!string.IsNullOrEmpty(newItem))
            {
                toDoList.Add(newItem);
                listBox1.Items.Add(newItem);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Populate the listbox with the items in the to-do list
            foreach (var item in toDoList)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}

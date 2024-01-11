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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            listBoxItems.Items.Add("Iasi");
            listBoxItems.Items.Add("Suceava");
            listBoxItems.Items.Add("Bacau");
            listBoxItems.Items.Add("Vaslui");
            listBoxItems.Items.Add("Galati");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count > 0)
            {
                string selectedItems = "";

                foreach (object city in listBoxItems.SelectedItems)
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

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string newItem = Interaction.InputBox(
                "Enter a new item:", "Add Item"
            );

            if (
                !string.IsNullOrEmpty(newItem) &&
                !listBoxItems.Items.Contains(newItem)
            )
            {
                listBoxItems.Items.Add(newItem);
            }
            else
            {
                MessageBox.Show(
                    "Item already exists or no " +
                    "item was entered!"
                );
            }
        }

        private void buttonDesleteItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count > 0)
            {
                while (listBoxItems.SelectedItems.Count > 0)
                {
                    listBoxItems.Items.Remove(
                        listBoxItems.SelectedItems[0]
                    );
                }
            }
            else
            {
                MessageBox.Show("No items are selected!");
            }
        }
    }
}

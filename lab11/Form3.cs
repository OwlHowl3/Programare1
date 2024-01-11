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

namespace lab11
{
    // Defineste o structura Phones

    // Creeaza o lista de Phones la nivelul clasei

    // La click pe primul buton - preia valori din textbox si 
    // creeaza un obiect nou de tip Phone, actualizand si proprietatile acestuia
    // Adauga la lista de phones.
    // Adauga brandul in combobox daca acesta nu exista acolo.

    // la click pe al doilea buton - preia valoarea din combobox
    // calculeaza totalul de pret pentru valoarea brandului selectat.

    public partial class Form3 : Form
    {
        public List<Phone> phones = new List<Phone>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone();

            newPhone.id = int.Parse(textBox1.Text);
            newPhone.brand = textBox2.Text;
            newPhone.model = textBox3.Text;
            newPhone.price = double.Parse(textBox4.Text);

            this.phones.Add(newPhone);

            if (!comboBox1.Items.Contains(newPhone.brand))
            {
                comboBox1.Items.Add(newPhone.brand);
            }

            MessageBox.Show("Phone added");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalValue = 0;

            foreach (Phone phone in this.phones)
            {
                if (phone.brand == comboBox1.SelectedItem.ToString())
                {
                    totalValue += phone.price;
                }
            }

            MessageBox.Show(
                "Total value of brand " + 
                comboBox1.SelectedItem.ToString() +
                " is " + totalValue.ToString()
            );
        }
    }

    public struct Phone
    {
        public int id;
        public string brand;
        public string model;
        public double price;
    }
}

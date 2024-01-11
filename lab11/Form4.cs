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

namespace lab11
{
    public partial class Form4 : Form
    {
        // Defineste o structura Smartphone

        // Creeaza o lista de Smartphones la nivelul clasei

        // La click pe primul buton, preia numarul N din textbox si 
        // creeaza N obiecte de tip Smartphone, preluand de la utilizator 
        // valori pentru cele 4 proprietati ale fiecarui smartphone (Interaction.InputBox)


        // La click pe al doilea buton, concateneaza informatiile despre
        // telefoane intr-un string si afiseaza-le intr-un label.

        public List<Smartphone> phones = new List<Smartphone>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nrItems = int.Parse(textBox1.Text);

            for (int i = 0; i < nrItems; i++)
            {
                int id = int.Parse(Interaction.InputBox("Give me the Id"));
                string brand = Interaction.InputBox("Give me the brand");
                string model = Interaction.InputBox("Give me the model");
                double price = double.Parse(Interaction.InputBox("Give me the price"));

                Smartphone newPhone = new Smartphone(id, brand, model, price);
                
                this.phones.Add(newPhone);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newDisplayText = "";

            foreach (Smartphone phone in this.phones)
            {
                newDisplayText += "\nId: " + phone.id + "; " +
                    "brand: " + phone.brand + 
                    "; model" + phone.model + 
                    "; price: " + phone.price; 
            }

            label2.Text = newDisplayText;
        }
    }

    public struct Smartphone
    {
        public int id;
        public string brand;
        public string model;
        public double price;

        public Smartphone(int id, string brand, string model, double price)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.price = price;
        }
    }
}

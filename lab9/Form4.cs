using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab9
{
    public partial class Form4 : Form
    {
        // Creeaza 5 liste cu trupe/interpreti rock, metal, folk, rap si pop
        // la nivelul clasei

        // La incarcarea formularului adauga 5 itemi in combobox - 
        // rock, metal, folk, rap, pop

        // la schimbarea valorii din combobox - populeaza listboxul cu valorile
        // din lista corespunzatoare de interpreti. 

        // la click pe butonul "add band" adauga elementul in listbox
        // si in lista corespunzatoare

        // la click pe display preia toate valorile din inputuri si 
        // afiseaza-le in label


        private List<string> rockList = new List<string>() {
            "Pink Floyd","Led Zeppelin", "Queen", "Guns N' Roses"
        };

        private List<string> metalList = new List<string>() {
            "Metallica", "Iron Maiden", "Slayer", "Black Sabbath", "Bucovina"
        };

        private List<string> folkList = new List<string>() {
            "Bon Iver",  "Simon and Garfunkel", "The Lumineers", "Mumford & Sons"
        };
        private List<string> rapList = new List<string>() {
            "Eminem", "Jay Z", "Kanye West", "Kendrick Lamar", "Lil Wayne"
        };
        private List<string> popList = new List<string>() {
            "Lady Gaga", "Beyonce", "Taylor Swift", "Katty Perry", "Dua Lipa"
        };

        public Form4()
        {
            InitializeComponent();

            // Populate the combo box with the music genres

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rock");
            comboBox1.Items.Add("Metal");
            comboBox1.Items.Add("Folk");
            comboBox1.Items.Add("Rap");
            comboBox1.Items.Add("Pop");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate the listbox with the bands corresponding to the selected genre
            listBox1.Items.Clear();

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Rock":
                    foreach (var band in rockList)
                    {
                        listBox1.Items.Add(band);
                    }
                    break;
                case "Metal":
                    foreach (var band in metalList)
                    {
                        listBox1.Items.Add(band);
                    }
                    break;
                case "Folk":
                    foreach (var band in folkList)
                    {
                        listBox1.Items.Add(band);
                    }
                    break;
                case "Rap":
                    foreach (var band in rapList)
                    {
                        listBox1.Items.Add(band);
                    }
                    break;
                case "Pop":
                    foreach (var band in popList)
                    {
                        listBox1.Items.Add(band);
                    }
                    break;
                default:
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newArtist = Interaction.InputBox("Enter a new artist name");

            if (!string.IsNullOrEmpty(newArtist))
            {
                listBox1.Items.Add(newArtist);

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Rock":
                        rockList.Add(newArtist);
                        break;
                    case "Metal":
                        metalList.Add(newArtist);
                        break;
                    case "Folk":
                        folkList.Add(newArtist);
                        break;
                    case "Rap":
                        rapList.Add(newArtist);
                        break;
                    case "Pop":
                        popList.Add(newArtist);
                        break;
                    default:
                        return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Music Preferences";
            label4.Text += "\nName: " + textBox1.Text;
            label4.Text += "\nFavourite Music Genre: " +
                comboBox1.SelectedItem.ToString();

            if (listBox1.SelectedItems.Count > 0)
            {
                string selectedItems = "";

                foreach (object artist in listBox1.SelectedItems)
                {
                    selectedItems += artist.ToString() + ",";
                }
                selectedItems = selectedItems.TrimEnd(',', ' ');
                label4.Text += "\nFavourite Artists: " + selectedItems;
            }
            else
            {
                label4.Text += "\nNo favourite bands selected";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

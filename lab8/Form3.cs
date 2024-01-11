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
    public partial class Form3 : Form
    {
        string campus;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkBoxAccomodation.CheckState = CheckState.Unchecked;
            groupBoxCampus.Visible = false;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastName.Text;
            string locality = textBoxLocality.Text;
            string accomodation;
            string transport;
            double gpa;
            double scolarship;

            try
            {
                gpa = Double.Parse(textBoxGPA.Text);
            }
            catch (Exception ex)
            {s
                MessageBox.Show("Gpa should be a number");
                return;
            }

            if (gpa < 8.5)
            {
                scolarship = 0;
            }
            else if (gpa <= 9)
            {
                scolarship = 400;
            }
            else if (gpa <= 9.5)
            {
                scolarship = 550;
            }
            else
            {
                scolarship = 700;
            }

            if (checkBoxAccomodation.Checked == true)
            {
                accomodation = "Needs accomodation in campus";
            }
            else
            {
                accomodation = "Does not need accomodation in campus";
            }

            if (checkBoxTransport.Checked == true)
            {
                transport = "Needs transport facility";
            }
            else
            {
                transport = "Does not need transport facility";
            }

            labelInfo.Text = "Student " + firstname + " " + lastname +
                " from " + locality +
                " has a scolarship of " + scolarship + " euros. " + 
                "\n" + accomodation + " " + campus +
                "\n" + transport;
        }

        private void checkBoxAccomodation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccomodation.Checked == true)
            {
                groupBoxCampus.Visible = true;
                radioButtonTituMaiorescu.Checked = true;
                campus = "Titu Maiorescu";
            }
            else
            {
                groupBoxCampus.Visible = false;
                campus = "";
            }
        }

        private void radioButtonTituMaiorescu_CheckedChanged(object sender, EventArgs e)
        {
            campus = "Titu Maiorescu";
        }

        private void radioButtonCodrescu_CheckedChanged(object sender, EventArgs e)
        {
            campus = "Codrescu";
        }

        private void radioButtonTargusorCopou_CheckedChanged(object sender, EventArgs e)
        {
            campus = "Targusor Copou";
        }
    }
}

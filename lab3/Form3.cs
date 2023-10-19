using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form3 : Form
    {
        // Defineste un vector de salarii

        // Calculeaza minimul, maximul, totalul si media din acel vector

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int[] salaries = new int[] { 6000, 6000, 1600, 2400, 2200, 2600, 1200, 3000, 4500, 6000 };

            int minSalary = salaries[0];
            int countMin = 1;

            for (int i = 1; i< salaries.Length; i++)
            {
                if (salaries[i] == minSalary)
                {
                    countMin++;
                }
                if (salaries[i] < minSalary)
                {
                    minSalary = salaries[i];
                    countMin = 1;
                } 
            }

            Console.WriteLine("Min salary is " + minSalary + " and is present " + countMin + " times.");


            int maxSalary = salaries[0];
            int countMax = 1;

            for (int i = 1; i < salaries.Length; i++)
            {
                if (salaries[i] == maxSalary)
                {
                    countMax++;
                }
                if (salaries[i] > maxSalary)
                {
                    maxSalary = salaries[i];
                    countMax = 1;
                }
            }

            Console.WriteLine("Max salary is " + maxSalary + " and is present " + countMax + " times.");


            double meanSalary;
            int totalSalary = 0;

            for (int i = 0; i < salaries.Length; i++)
            {
                totalSalary += salaries[i];
            }

            meanSalary = (double)totalSalary / (double)salaries.Length;

            Console.WriteLine("Total salary: " + totalSalary);
            Console.WriteLine("Mean salary: " + meanSalary);
        }
    }
}

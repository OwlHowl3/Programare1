using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    // 1. Creare metoda pentru calcul arie dreptunghi

    // 2. Creare metoda pentru extragerea valorii maxime dintr-un vector

    // 3. Creare metoda pentru calcul distanta dintre doua puncte
    //    intr-un plan 2d
    
    // 4. Creare metoda pentru impartirea unei sume de bani in 
    //    cat mai putine bancnote

    // 5. Creare metoda pentru convertire secunde in formatul
    //    ore:minute:secunde

    // 6. Create metoda pentru afisarea unui brad in consola
    public partial class Form1 : Form
    {
        private double RectangleArea(double a, double b)
        {
            //double area = a * b;
            //return area;

            return a * b;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private double MaxValue(double[] vector)
        {
            double max = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > max)
                {
                    max = vector[i];
                }
            }

            return max;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            double[] vv = new double[] { 0.5, 6.1, 7.9, 7.5 };
            double maxValue = MaxValue(vv);
            Console.WriteLine(maxValue);


            Console.WriteLine(this.RectangleArea(2, 6));
            double result = this.RectangleArea(2, 6);
            Console.WriteLine(result.ToString());

            Console.WriteLine(DistanceBetweenPoints(25, 35, 15, 10));

            BreakIntoBanknotes(375);

            ConvertSeconds(25300);

            //DrawChristmasTree(2);
            DrawChristmasTree(3);
            //DrawChristmasTree(4);
            //DrawChristmasTree(7);
        }
    

        static void DrawChristmasTree(int levels)
        {
            for (int i = 1; i <= levels; i++)
            {
                for (int space = 1; space <= (levels - i); space++)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }

                for (int star = (i - 1); star >= 1; star--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }



        static double DistanceBetweenPoints(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(
                Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)
            );
        }

        static void BreakIntoBanknotes(int amount)
        {
            Console.WriteLine("Input amount: " + amount);
            Console.WriteLine("There are:");

            int total;

            total = amount / 100;
            Console.WriteLine(total + " banknotes of 100");

            amount = amount - (total * 100);

            total = amount / 50;
            Console.WriteLine(total + " banknotes of 50");

            amount = amount - (total * 50);

            total = amount / 20;
            Console.WriteLine(total + " banknotes of 20");

            amount = amount - (total * 20);

            total = amount / 10;
            Console.WriteLine(total + " banknotes of 10");

            amount = amount - (total * 10);

            total = amount / 5;
            Console.WriteLine(total + " banknotes of 5");

            amount = amount - (total * 5);

            total = (int)amount / 1;
            Console.WriteLine(total + " banknotes of 1");


            //Console.WriteLine(amount + " banknotes of 1");
        }
        static void ConvertSeconds(int secondsTotal)
        {
            int hours = (secondsTotal / 3600);
            int minutes = (secondsTotal - (3600 * hours)) / 60;
            int seconds = (secondsTotal - (3600 * hours) - (minutes * 60));

            string output = String.Format("H:M:S - {0}:{1}:{2}", hours, minutes, seconds);

            Console.WriteLine(output);
        }
    }
}

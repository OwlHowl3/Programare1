using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i * j);
                    if (numberOfDigits(i * j) == 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static int numberOfDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }

            return count;
        }
    }
}

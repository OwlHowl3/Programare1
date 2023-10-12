using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class P1
    {
        // Even or Odd Number Checker:
        public static void solver()
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadLine();
        }
    }
}

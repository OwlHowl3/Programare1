using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class P5
    {
        // Sum of digits
        public static void solver()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int temp = num;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += digit;
                temp /= 10;
            }

            Console.WriteLine($"Sum of digits of {num} is {sum}");
            Console.ReadLine();
        }
    }
}

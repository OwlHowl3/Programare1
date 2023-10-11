using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Temperature converter C to F
    internal class P4
    {
        public static void solver()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class P2
    {
        // Simple calculator
        public static void solver()
        {
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);

            Console.Write("Enter an operator (+, -, *, /): ");
            string input2 = Console.ReadLine();
            char op = Convert.ToChar(input2);

            Console.Write("Enter second number: ");
            string input3 = Console.ReadLine();
            double num2 = Convert.ToDouble(input3);

            double result = 0.0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class P6
    {
        // Palindrom checker
        public static void solver()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            bool isPalindrome = true;

            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("It's a palindrome!");
            }
            else
            {
                Console.WriteLine("It's not a palindrome.");
            }
            Console.ReadLine();
        }
    }
}

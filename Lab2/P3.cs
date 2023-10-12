using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class P3
    {
        // Guess the number game
        public static void solver()
        {
            Random random = new Random();
            int target = random.Next(1, 101);
            int guess;
            int attempts = 0;

            Console.WriteLine("Guess the number between 1 and 100.");

            do
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                guess = Convert.ToInt32(input);
                attempts++;

                if (guess < target)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it in {attempts} attempts.");
                }
            } while (guess != target);
            Console.ReadLine();

        }
    }
}

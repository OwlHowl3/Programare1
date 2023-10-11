using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class P7
    {
        // Rock paper scissors game
        public static void solver()
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();

            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.Write("Enter your choice (rock, paper, or scissors): ");
            string userChoice = Console.ReadLine().ToLower();

            int randomIndex = random.Next(choices.Length);
            string computerChoice = choices[randomIndex];

            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == "rock" && computerChoice == "scissors" ||
                     userChoice == "paper" && computerChoice == "rock" ||
                     userChoice == "scissors" && computerChoice == "paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
            Console.ReadLine();
        }
    }
}

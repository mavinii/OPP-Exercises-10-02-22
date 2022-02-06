using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exercises_10_02_22.Exercises
{
    public class Exercise3
    {
        public void GuessNumber()
        {
            // Ansking user a num
            Console.Write("\nGuess a number between 1 to 10: ");
            int answer = int.Parse(Console.ReadLine());

            // It gererates a ramdom num
            Random randomGenerator = new();
            int ramdomNum = randomGenerator.Next(1, 10);

            // Checking if users' num is iqual to ramdom num
            if (answer == ramdomNum)
            {
                Console.WriteLine($"Well done! {answer} is igual to {ramdomNum}!");

                // Asking user for playing again
                Console.Write("Do you want to play again? Y/N: ");
                string question = Console.ReadLine();

                // It will keep looping until the user types Y, y, N, n
                while (question != "Y" && question != "y" && question != "N" && question != "n")
                {
                    Console.Write($"{question} does not exists! Please type Y/N: ");
                    question = Console.ReadLine();
                }

                if (question == "Y" || question == "y")
                {
                    GuessNumber();
                }
                else
                {
                    Console.WriteLine("Bye!");
                }
            }
            else
            {
                Console.WriteLine($"Ops, {answer} is NOT igual to {ramdomNum}!");

                // Asking user for playing again
                Console.Write("Do you want to play again? Y/N: ");
                string question = Console.ReadLine();

                while (question != "Y" && question != "y" && question != "N" && question != "n")
                {
                    Console.Write($"{question} does not exists! Please type Y/N: ");
                    question = Console.ReadLine();
                }

                if (question == "Y" || question == "y")
                {
                    GuessNumber();
                } else
                {
                    Console.WriteLine("Bye!");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  22931 - Marcos Oliveira

//  Write a console-based application that prompts a user for an hourly pay rate. While the user 
//  enters values less than $5.65 or greater than $49.99, continue to prompt the user. Before the 
//  program ends, display the valid pay rate.

namespace OPP_Exercises_10_02_22.Exercises
{
    public class Exercise1
    {
        public void HourlyPayRate()
        {

            Console.Write("Please enter for an hourly pay rate: $");
            // Ask the professor what does it "_ = double..." mean
            _ = double.TryParse(Console.ReadLine(), out double answer);

            // Verification
            while (answer < 5.65 || answer > 49.99)
            {
                Console.WriteLine($"${answer} is not allowed! Try again between $5.65 and $49.99.");

                Console.Write("\nPlease enter for an hourly pay rate: $");
                // Ask the professor what does it "_ = double..." mean
                _ = double.TryParse(Console.ReadLine(), out answer);
            }

            Console.WriteLine($"Valid pay rate is ${answer}.");
            Console.ReadLine();
        }
    }
}

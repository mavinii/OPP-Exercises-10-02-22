using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  22931 - Marcos Oliveira
// Write a console-based application that sums the integers from 1 to 50

namespace OPP_Exercises_10_02_22.Exercises
{
    public class Exercise2
    {
        public void SumsIntegers()
        {
            // USING FOR
            double sum = 0;
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"counting: {i}");
                sum += i;
            }
            Console.WriteLine($"The sum from 0 to 50 is: {sum}.");

            // USING Enumerable
            var answer = Enumerable.Range(0, 50);
            Console.WriteLine("The sum from 0 to 50 is:" + answer.Sum());
        }
    }
}

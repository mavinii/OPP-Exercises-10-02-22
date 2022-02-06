using OPP_Exercises_10_02_22.Exercises;
using System;

//  22931 Marcos Oliveira
namespace OPP_Exercises_10_02_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPP - Exercises Class 10/02\n");

            // Exercise 1
            Exercise1 exercise1 = new();
            exercise1.HourlyPayRate();

            // Exercise 2
            Exercise2 exercise2 = new();
            exercise2.SumsIntegers();

            // Exercise 3
            Exercise3 exercise3 = new();
            exercise3.GuessNumber();
        }
    }
}

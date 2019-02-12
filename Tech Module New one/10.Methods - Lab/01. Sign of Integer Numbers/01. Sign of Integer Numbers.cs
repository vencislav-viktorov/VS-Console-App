using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number {number} " +
                $"is {CheckNumberIsPossitiveNegativeOrZero(number)}.");

        }

        static string CheckNumberIsPossitiveNegativeOrZero(int number)
        {
            if (number > 0)
            {
                return "positive";
            }

            else if (number < 0)
            {
                return "negative";
            }

            else
            {
                return "zero";
            }
        }
    }
}

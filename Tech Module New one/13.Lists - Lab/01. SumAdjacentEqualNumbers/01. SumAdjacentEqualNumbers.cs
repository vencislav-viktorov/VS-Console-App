using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                double currentNumber = numbers[i];
                double nextNumber = numbers[i + 1];

                if (currentNumber == nextNumber)
                {
                    numbers[i] *= 2;
                    numbers.Remove(nextNumber);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int originalLength = numbers.Count;

            for (int i = 0; i < originalLength / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];

                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

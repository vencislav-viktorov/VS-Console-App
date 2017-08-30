using System;
using System.Linq;

namespace _01.Array_Statistics
{
    public class Array_Statistics
    {
        public static void Main()
        {
            var numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int min = numArray.Min();

            int max = numArray.Max();

            int sum = numArray.Sum();

            double average = numArray.Average();

            Console.WriteLine($"Min = {min}");

            Console.WriteLine($"Max = {max}");

            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine($"Average = {average}");
        }
    }
}

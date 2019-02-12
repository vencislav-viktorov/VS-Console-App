using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> result = new List<double>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                var first = numbers[i];

                var last = numbers[numbers.Count - 1 - i];

                var resultNumber = first + last;

                result.Add(resultNumber);
            }

            if (numbers.Count % 2 != 0)
            {
                var middle = numbers[numbers.Count / 2];
                result.Add(middle);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

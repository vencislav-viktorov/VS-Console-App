using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] roundedNumbers = new int[numbers.Length];

                roundedNumbers[i] = (int)Math.Round(numbers[i],
                    MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}

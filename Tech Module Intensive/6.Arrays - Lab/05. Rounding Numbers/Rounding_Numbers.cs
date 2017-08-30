using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    public class Rounding_Numbers
    {
        public static void Main()
        {
            double[] numbers = ReadNumbers();

            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i],
                MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} -> {roundedNumbers[i]}");
            }
        }

        static double[] ReadNumbers()
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToArray();

            return numbers;
        }
    }
}

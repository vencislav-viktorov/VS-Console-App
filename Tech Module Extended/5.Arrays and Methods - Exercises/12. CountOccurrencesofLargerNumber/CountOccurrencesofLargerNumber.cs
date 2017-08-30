using System;
using System.Linq;

namespace _12.CountOccurrencesofLargerNumber
{
    public class CountOccurrencesofLargerNumber
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double number = double.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > number)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

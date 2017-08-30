using System;
using System.Linq;

namespace _07.Sum_Arrays
{
    public class Sum_Arrays
    {
        public static void Main()
        {
            int[] arrayOne = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToArray();

            int[] arrayTwo = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            int[] sumArray = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
            }

            foreach (int sum in sumArray)
            {
                Console.Write($"{sum} ");
            }
        }
    }
}

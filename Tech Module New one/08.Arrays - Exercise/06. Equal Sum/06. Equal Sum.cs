using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;

            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum += numbers[i];
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                rightSum -= numbers[j];

                if (rightSum == leftSum)
                {
                    Console.WriteLine(j);
                    return;
                }

                leftSum += numbers[j];
            }

            Console.WriteLine("no");
        }
    }
}

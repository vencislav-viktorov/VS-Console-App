using System;
using System.Linq;

namespace _02._FromLefttoTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                long sumOfDigits = 0;

                if (arr[0] > arr[1])
                {
                    long currentNum = arr[0];

                    while (currentNum != 0)
                    {
                        sumOfDigits += currentNum % 10;
                        currentNum /= 10;
                    }
                }

                else
                {
                    long currentNum = arr[1];

                    while (currentNum != 0)
                    {
                        sumOfDigits += currentNum % 10;
                        currentNum /= 10;
                    }
                }

                Console.WriteLine(Math.Abs(sumOfDigits));
            }
        }
    }
}
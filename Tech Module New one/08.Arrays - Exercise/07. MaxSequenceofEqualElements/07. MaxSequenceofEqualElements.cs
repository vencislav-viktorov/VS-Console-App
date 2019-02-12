using System;
using System.Linq;

namespace _07._MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int digitNum = numbers[0];
            int counter = 1;
            int maxLength = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }

                else
                {
                    counter = 1;
                }

                if (counter > maxLength)
                {
                    maxLength = counter;
                    digitNum = numbers[i];
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(digitNum + " ");
            }

            Console.WriteLine();
        }
    }
}


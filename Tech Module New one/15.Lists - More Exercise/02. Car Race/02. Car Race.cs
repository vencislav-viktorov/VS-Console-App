using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftRacerSum = 0;

            double rightRacerSum = 0;

            int final = numbers.Count / 2;

            for (int i = 0; i < final; i++)
            {
                if (numbers[i] == 0)
                {
                    leftRacerSum *= 0.8;
                }

                leftRacerSum += numbers[i];
            }

            for (int i = numbers.Count - 1; i > final; i--)
            {
                if (numbers[i] == 0)
                {
                    rightRacerSum *= 0.8;
                }

                rightRacerSum += numbers[i];
            }

            if (leftRacerSum < rightRacerSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerSum}");
            }

            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerSum}");
            }
        }
    }
}

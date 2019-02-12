using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            int rotationTimes = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationTimes; i++)
            {
                string firstDigits = input[0];

                for (int j = 0; j < input.Length; j++)
                {
                    if (j < input.Length - 1)
                    {
                        input[j] = input[j + 1];

                    }

                    else
                    {
                        input[j] = firstDigits;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int result = GetSumOfChar(input[0], input[1]);

            Console.WriteLine(result);
        }

        private static int GetSumOfChar(string firstString, string secondString)
        {
            int minLenght = Math.Min(firstString.Length, secondString.Length);

            int result = 0;

            for (int i = 0; i < minLenght; i++)
            {
                result += firstString[i] * secondString[i];
            }

            if (firstString.Length > secondString.Length)
            {
                for (int i = firstString.Length - (firstString.Length - secondString.Length); i < firstString.Length; i++)
                {
                    result += firstString[i];
                }
            }
            else if (secondString.Length > firstString.Length)
            {
                for (int i = secondString.Length - (secondString.Length - firstString.Length); i < secondString.Length; i++)
                {
                    result += secondString[i];
                }
            }

            return result;
        }
    }
}
using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = input[0].ToString();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != result[result.Length - 1])
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}

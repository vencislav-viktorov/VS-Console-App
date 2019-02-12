using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            string text1 = string.Empty;
            string text2 = string.Empty;


            for (int i = 1; i <= linesCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                if (i % 2 != 0)
                {
                    text1 += input[0] + " ";
                    text2 += input[1] + " ";
                }
                else
                {
                    text1 += input[1] + " ";
                    text2 += input[0] + " ";
                }
            }

            Console.WriteLine(text1);
            Console.WriteLine(text2);
        }
    }
}

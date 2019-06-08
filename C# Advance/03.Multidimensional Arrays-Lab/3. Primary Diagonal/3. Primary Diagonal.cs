using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < linesCount; i++)
            {
                var row = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                sum += row[i];
            }

            Console.WriteLine(sum);
        }
    }
}

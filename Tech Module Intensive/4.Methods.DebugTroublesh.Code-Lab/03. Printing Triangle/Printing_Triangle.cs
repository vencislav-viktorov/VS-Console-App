using System;

namespace _03.Printing_Triangle
{
    public class Printing_Triangle
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColumns(row);
            }

            for (int row = n - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}

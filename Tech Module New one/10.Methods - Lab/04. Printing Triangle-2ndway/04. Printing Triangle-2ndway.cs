using System;

namespace _04._Printing_Triangle_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintUpperPartOfTriangle(number);
            PrintBottomPartOfTriangle(number);
        }

        private static void PrintUpperPartOfTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintCowOfTriangle(1, row);
            }
        }

        private static void PrintCowOfTriangle(int start, int end)
        {
            for (int cow = start; cow <= end; cow++)
            {
                Console.Write(cow + " ");
            }

            Console.WriteLine();
        }

        private static void PrintBottomPartOfTriangle(int number)
        {
            for (int row = number - 1; row >= 1; row--)
            {
                PrintCowOfTriangle(1, row);
            }
        }
    }
}

using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintingTriangle(number);
        }

        static void PrintingTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write(cow + " ");
                }

                Console.WriteLine();
            }

            for (int row = number - 1; row >= 1; row--)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write(cow + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

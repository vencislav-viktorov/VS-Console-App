using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrix(number);
        }

        static void PrintMatrix(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int cow = 0; cow < number; cow++)
                {
                    Console.Write(number +  " ");
                }

                Console.WriteLine();
            }
        }
    }
}

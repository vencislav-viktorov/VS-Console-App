using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowInput = int.Parse(Console.ReadLine());

            for (int row = 0; row < rowInput; row++)
            {
                int number = 1;

                for (int cow = 0; cow <= row; cow++)
                {
                    Console.Write(number + " ");

                    number = number * (row - cow) / (cow + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
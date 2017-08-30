using System;

namespace _10.Triangle_of_Numbers
{
    public class Triangle_of_Numbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
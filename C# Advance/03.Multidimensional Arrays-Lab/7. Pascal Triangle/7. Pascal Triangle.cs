using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascalArray = new long[rows][];

            for (int i = 0; i < pascalArray.Length; i++)
            {
                pascalArray[i] = new long[i + 1];
                pascalArray[i][0] = 1;
                pascalArray[i][i] = 1;
            }

            for (int row = 2; row < pascalArray.Length; row++)
            {
                for (int col = 1; col < pascalArray[row].Length - 1; col++)
                {
                    pascalArray[row][col] = pascalArray[row - 1][col - 1] + pascalArray[row - 1][col];
                }
            }

            for (int i = 0; i < pascalArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", pascalArray[i]));
            }
        }
    }
}

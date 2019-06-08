using System;
using System.Linq;

namespace _06._Bomb_the_Basement
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
            }

            var bomb = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bombRow = bomb[0];
            var bombCol = bomb[1];
            var radius = bomb[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var distance = Math.Sqrt(Math.Pow(row - bombRow, 2) +
                        Math.Pow(col - bombCol, 2));

                    if (distance <= radius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            var secondMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];

                for (int col = 0; col < rows; col++)
                {
                    secondMatrix[row][col] = matrix[col][row];
                }

                secondMatrix[row] = secondMatrix[row]
                    .OrderByDescending(x => x)
                    .ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = secondMatrix[col][row];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join("", r))));
        }
    }
}

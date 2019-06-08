using System;
using System.Linq;

namespace _04._The_Matrix
{
    class Program
    {
        public static int rows;
        public static int cols;

        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            rows = tokens[0];
            cols = tokens[1];
            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();
            }

            var fillChar = char.Parse(Console.ReadLine());
            tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var startRow = tokens[0];
            var startCol = tokens[1];
            var toBeReplace = matrix[startRow][startCol];

            ColorMatrix(matrix, startRow, startCol, fillChar, toBeReplace);

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    Console.Write(matrix[currentRow][currentCol]);
                }

                Console.WriteLine();
            }
        }

        private static void ColorMatrix(char[][] matrix, int row, int col, char fillChar, char toBeReplace)
        {
            if (!IsInBounds(row, col) ||
                matrix[row][col] == fillChar ||
                matrix[row][col] != toBeReplace)
            {
                return;
            }

            matrix[row][col] = fillChar;
            ColorMatrix(matrix, row + 1, col, fillChar, toBeReplace);
            ColorMatrix(matrix, row - 1, col, fillChar, toBeReplace);
            ColorMatrix(matrix, row, col + 1, fillChar, toBeReplace);
            ColorMatrix(matrix, row, col - 1, fillChar, toBeReplace);
        }

        private static bool IsInBounds(int row, int col)
        {
            return row < rows && row >= 0 &&
                col < cols && col >= 0;
        }
    }
}
using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rowsCount = rowsAndColsCount[0];
            var colsCount = rowsAndColsCount[1];
            var matrix = new int[rowsCount, colsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries )
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var maxSum3x3 = int.MinValue;
            var maxStartRow = 0;
            var maxStartCol = 0;
            
            for (int row = 0; row < rowsCount - 2; row++)
            {
                for (int col = 0; col < colsCount - 2; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (maxSum3x3 < currentSum)
                    {
                        maxSum3x3 = currentSum;
                        maxStartRow = row;
                        maxStartCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum3x3}");

            for (int row = maxStartRow; row <= maxStartRow + 2; row++)
            {
                for (int col = maxStartCol; col <= maxStartCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

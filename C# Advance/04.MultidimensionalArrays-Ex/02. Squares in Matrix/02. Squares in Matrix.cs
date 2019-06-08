using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rowsCount = rowsAndColsCount[0];
            var colsCount = rowsAndColsCount[1];
            var matrix = new string[rowsCount, colsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var countSameMatrix2x2 = 0;

            for (int row = 0; row < rowsCount - 1; row++)
            {
                for (int col = 0; col < colsCount - 1; col++)
                {
                    var symbol = matrix[row, col];

                    if (matrix[row, col] == symbol && 
                        matrix[row, col + 1] == symbol && 
                        matrix[row + 1, col] == symbol &&
                        matrix[row + 1, col + 1] == symbol)
                    {
                        countSameMatrix2x2++;
                    }
                }
            }

            Console.WriteLine(countSameMatrix2x2);
        }
    }
}
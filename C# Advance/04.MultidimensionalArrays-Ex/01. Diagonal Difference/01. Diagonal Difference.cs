using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = int.Parse(Console.ReadLine());
            var matrix = new int[rowsAndColsCount, rowsAndColsCount];
        
            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;

            for (int row = 0; row < rowsAndColsCount; row++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                primaryDiagonal += input[row];
                secondaryDiagonal += input[rowsAndColsCount - 1 - row];

                for (int col = 0; col < rowsAndColsCount; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var result = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(result);
        }
    }
}

using System;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = int.Parse(Console.ReadLine());

            var matrix = new char[rowsAndColsCount][];

            for (int row = 0; row < rowsAndColsCount; row++)
            {
                matrix[row] = Console.ReadLine()
                    .ToCharArray();
            }

            var removedHorses = 0;

            while (true)
            {
                var knightRow = -1;
                var knightCol = -1;
                var maxAttacked = 0;

                for (int row = 0; row < rowsAndColsCount; row++)
                {
                    for (int col = 0; col < rowsAndColsCount; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            var tempAttacked = CountAttacks(matrix, row, col);

                            if (tempAttacked > maxAttacked)
                            {
                                maxAttacked = tempAttacked;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (maxAttacked > 0)
                {
                    matrix[knightRow][knightCol] = '0';
                    removedHorses++;
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine(removedHorses);
        }

        private static int CountAttacks(char[][] matrix, int row, int col)
        {
            var attacks = 0;

            if (isInMatrix(row - 1, col - 2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row - 1, col + 2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row + 1, col - 2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row + 1, col + 2, matrix.Length) && matrix[row + 1][col + 2] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row - 2, col - 1, matrix.Length) && matrix[row - 2][col - 1] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row + 2, col - 1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
            {
                attacks++;
            }

            if (isInMatrix(row + 2, col + 1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
            {
                attacks++;
            }

            return attacks;
        }

        private static bool isInMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}

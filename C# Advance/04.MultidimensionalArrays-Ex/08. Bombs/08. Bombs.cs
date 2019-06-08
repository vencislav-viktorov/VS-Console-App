using System;
using System.Linq;

namespace _08._Bombs
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = int.Parse(Console.ReadLine());
            var matrix = new int[rowsAndColsCount][];

            for (int col = 0; col < rowsAndColsCount; col++)
            {
                matrix[col] = Console.ReadLine()
                    .Split(' ' , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var bombs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int bombExplode = 0; bombExplode < bombs.Length; bombExplode++)
            {
                var currentBomb = bombs[bombExplode]
                    .Split(",");
                var bombRow = int.Parse(currentBomb[0]);
                var bombCol = int.Parse(currentBomb[1]);
                var powerBomb = matrix[bombRow][bombCol];

                if (powerBomb > 0)
                {
                    for (int row = 0; row < rowsAndColsCount; row++)
                    {
                        for (int col = 0; col < rowsAndColsCount; col++)
                        {
                            if ((row != bombRow || col != bombCol) && matrix[row][col] > 0)
                            {
                                if ((row == bombRow - 1 || row == bombRow || row == bombRow + 1) &&
                                    (col == bombCol - 1 || col == bombCol || col == bombCol + 1))
                                {
                                    matrix[row][col] -= powerBomb;
                                }
                            }
                        }
                    }

                    matrix[bombRow][bombCol] = 0;
                }
            }

            var aliveCells = 0;
            var sum = 0;

            foreach (var row in matrix)
            {
                foreach (var element in row.Where(c => c > 0))
                {
                    sum += element;
                    aliveCells++;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

    }
}

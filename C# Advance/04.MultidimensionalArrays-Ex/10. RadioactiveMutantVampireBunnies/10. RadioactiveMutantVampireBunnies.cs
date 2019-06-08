using System;
using System.Linq;

namespace _10._RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rows = rowsAndColsCount[0];
            var cols = rowsAndColsCount[1];
            var matrix = new char[rows][];
            var playerRow = -1;
            var playerCol = -1;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();

                if (matrix[row].Contains('P'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(matrix[row], 'P');
                    matrix[playerRow][playerCol] = '.';
                }
            }

            var moves = Console.ReadLine();

            foreach (var move in moves)
            {
                var newPlayerRow = playerRow;
                var newPlayerCol = playerCol;

                switch (move)
                {
                    case 'U':
                        newPlayerRow -= 1;
                        break;

                    case 'R':
                        newPlayerCol += 1;
                        break;

                    case 'L':
                        newPlayerCol -= 1;
                        break;

                    case 'D':
                        newPlayerRow += 1;
                        break;

                    default:
                        break;
                }

                matrix = SpreadTheBunnies(matrix, rows, cols);

                if (newPlayerRow >= 0 && newPlayerRow < rows
                    && newPlayerCol >= 0 && newPlayerCol < cols)
                {
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    
                    if (matrix[playerRow][playerCol] == 'B')
                    {
                        PrintTheMatrix(matrix);
                        Console.WriteLine($"dead: {playerRow} {playerCol}");
                        return;
                    }
                }

                else
                {
                    PrintTheMatrix(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }
            }
        }

        private static void PrintTheMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static char[][] SpreadTheBunnies(char[][] matrix, int rows, int cols)
        {
            var newMatrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                newMatrix[i] = matrix[i].ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        if (row - 1 >= 0)
                        {
                            newMatrix[row - 1][col] = 'B';
                        }

                        if (row + 1 < rows)
                        {
                            newMatrix[row + 1][col] = 'B';
                        }

                        if (col - 1 >= 0)
                        {
                            newMatrix[row][col - 1] = 'B';
                        }

                        if (col + 1 < cols)
                        {
                            newMatrix[row][col + 1] = 'B';
                        }
                    }
                }
            }

            return newMatrix;
        }
    }
}
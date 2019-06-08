using System;
using System.Linq;

namespace _09._Miner
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsCount = int.Parse(Console.ReadLine());

            var commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var matrix = new char[rowsAndColsCount][];

            var playerRow = -1;
            var playerCol = -1;
            var coalLeft = 0;
            
            for (int row = 0; row < rowsAndColsCount; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();

                if (matrix[row].Contains('s'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(matrix[row], 's');
                    matrix[row][playerCol] = '*';
                }

                coalLeft += matrix[row].Where(c => c == 'c').Count();
            }

            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up":
                        playerRow = playerRow - 1 < 0 ? playerRow : playerRow - 1;
                        break;

                    case "down":
                        playerRow = playerRow + 1 >= rowsAndColsCount ? playerRow : playerRow + 1;
                        break;

                    case "left":
                        playerCol = playerCol - 1 < 0 ? playerCol : playerCol - 1;
                        break;

                    case "right":
                        playerCol = playerCol + 1 >= rowsAndColsCount ? playerCol : playerCol + 1;
                        break;
                }

                if (matrix[playerRow][playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    return;
                }

                else if (matrix[playerRow][playerCol] == 'c')
                {
                    matrix[playerRow][playerCol] = '*';
                    coalLeft--;

                    if (coalLeft == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{coalLeft} coals left. ({playerRow}, {playerCol})");
        }
    }
}
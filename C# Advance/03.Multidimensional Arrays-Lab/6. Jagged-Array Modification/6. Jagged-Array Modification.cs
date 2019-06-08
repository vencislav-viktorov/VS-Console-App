using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] arr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                arr[row] = new int[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    arr[row][col] = currentRow[col];
                }
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command.ToLower() == "end")
                {
                    break;
                }

                var commandParts = command.Split();

                var commandOperator = commandParts[0];

                var commandRow = int.Parse(commandParts[1]);

                var commandCol = int.Parse(commandParts[2]);

                var value = int.Parse(commandParts[3]);

                if (commandRow < 0 || commandRow >= arr.Length 
                    || commandCol < 0 || commandCol >= arr[commandRow].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandOperator == "Add")
                {
                    arr[commandRow][commandCol] += value;
                }

                else if (commandOperator == "Subtract")
                {
                    arr[commandRow][commandCol] -= value;
                }
            }

            foreach (var row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}

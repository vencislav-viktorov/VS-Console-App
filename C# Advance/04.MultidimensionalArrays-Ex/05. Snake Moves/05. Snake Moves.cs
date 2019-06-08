using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Snake_Moves
{
    class StartUp
    {
        static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new char[rows][];

            var snakeString = Console.ReadLine()
                .ToCharArray();

            var snakeQueue = new Queue<char>(snakeString);

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];

                for (int col = 0; col < cols; col++)
                {
                    var charToAdd = snakeQueue.Dequeue();
                    matrix[row][col] = charToAdd;
                    snakeQueue.Enqueue(charToAdd);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, 
                matrix.Select(r => string.Join("", r))));
        }
    }
}

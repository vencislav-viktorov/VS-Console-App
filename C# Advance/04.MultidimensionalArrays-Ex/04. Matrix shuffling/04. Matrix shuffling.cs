using System;
using System.Linq;

namespace _04._Matrix_shuffling
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new string[cols];
                matrix[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "swap" || tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                var x1 = int.Parse(tokens[1]);
                var y1 = int.Parse(tokens[2]);
                var x2 = int.Parse(tokens[3]);
                var y2 = int.Parse(tokens[4]);

                if (x1 < 0 || x1 >= rows || 
                    y1 < 0 || y1 >= cols ||
                    x2 < 0 || x2 >= rows ||
                    y2 < 0 || y2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                var firstElement = matrix[x1][y1];
                var secondElement = matrix[x2][y2];

                matrix[x1][y1] = secondElement;
                matrix[x2][y2] = firstElement;

                Console
                    .WriteLine(string
                    .Join(Environment.NewLine, matrix
                    .Select(r => string.Join(" ", r))));

                input = Console.ReadLine();
            }
        }
    }
}

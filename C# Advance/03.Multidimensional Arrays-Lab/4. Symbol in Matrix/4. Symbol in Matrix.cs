using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int rowsAndColsCount = int.Parse(Console.ReadLine());

            var matrix = new char[rowsAndColsCount, rowsAndColsCount];

            bool foundSymbol = false;

            int x = -1;
            int y = -1;

            for (int row = 0; row < rowsAndColsCount; row++)
            {
                var input = Console.ReadLine();

                var symbols = input.ToCharArray();

                for (int col = 0; col < rowsAndColsCount; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < rowsAndColsCount; row++)
            {
                if (foundSymbol)
                {
                    break;
                }

                for (int col = 0; col < rowsAndColsCount; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        foundSymbol = true;

                        x = row;
                        y = col;
                        break;
                    }
                }
            }

            if (foundSymbol)
            {
                Console.WriteLine($"({x}, {y})");
            }

            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}

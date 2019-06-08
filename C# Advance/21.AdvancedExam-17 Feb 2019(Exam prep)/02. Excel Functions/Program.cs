using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Excel_Functions
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var table = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                var rowValues = Console.ReadLine()
                    .Split(", ");

                table[i] = rowValues;
            }

            var commandArgs = Console.ReadLine()
                .Split(" ");

            var command = commandArgs[0];
            var header = commandArgs[1];

            var headerIndex = Array.IndexOf(table[0], header);

            if (command == "hide")
            {
                table.Where((x, y) => Array.IndexOf(x, y) != headerIndex);

                for (int row = 0; row < table.Length; row++)
                {
                    Console.WriteLine(string.Join(" | ", table[row]
                        .Where((x, y) => y != headerIndex)
                        .ToArray()));

                    //second way
                    //var lineToPrint = new List<string>(table[row]);
                    //lineToPrint.RemoveAt(headerIndex);
                    //Console.WriteLine(string.Join(" | ", lineToPrint));

                    //third way
                    //var lineToPrint = new List<string>();
                    //lineToPrint.AddRange(table[row].Take(headerIndex).ToList());
                    //lineToPrint.AddRange(table[row].Skip(headerIndex + 1));
                    //Console.WriteLine(string.Join(" | ", lineToPrint));
                }
            }

            else if (command == "sort")
            {
                var headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                table = table.OrderBy(x => x[headerIndex]).ToArray();
                
                foreach (var row in table)
                {
                    if (row != headerRow)
                    {
                        Console.WriteLine(string.Join(" | ", row));

                    }
                }
            }

            else if (command == "filter")
            {
                var parameter = commandArgs[2];
                var headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i][headerIndex] == parameter)
                    {
                        Console.WriteLine(string.Join(" | ", table[i]));
                    }
                }
            }
        }
    }
}
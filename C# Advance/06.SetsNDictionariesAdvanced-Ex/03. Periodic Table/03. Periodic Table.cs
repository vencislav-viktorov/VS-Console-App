using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main()
        {
            var chemicalSigns = new SortedSet<string>();
            var line = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    chemicalSigns.Add(input[j]);
                }
            }

            foreach (var item in chemicalSigns)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
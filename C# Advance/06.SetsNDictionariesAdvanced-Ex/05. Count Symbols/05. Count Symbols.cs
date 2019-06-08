using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main()
        {
            var symbols = new SortedDictionary<char, int>();

            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];

                if (symbols.ContainsKey(symbol) == false)
                {
                    symbols.Add(symbol, 0);
                }

                symbols[symbol]++;
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
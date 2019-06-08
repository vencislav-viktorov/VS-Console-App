using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            Stack<string> symbols = new Stack<string>(input.Reverse());

            var result = int.Parse(symbols.Pop());

            while (symbols.Any())
            {
                var nextSymbol = symbols.Pop();

                if (nextSymbol == "+")
                {
                    result += int.Parse(symbols.Pop());
                }

                else if (nextSymbol == "-")
                {
                    result -= int.Parse(symbols.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}

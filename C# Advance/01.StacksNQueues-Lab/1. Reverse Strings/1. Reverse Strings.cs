using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    public class Program
    {
        public static void Main()
        {
            var stack = new Stack<char>();

            var input = Console.ReadLine();

            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}

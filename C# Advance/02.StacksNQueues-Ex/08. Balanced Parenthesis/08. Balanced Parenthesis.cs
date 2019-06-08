using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    public class Program
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            var stack = new Stack<char>();

            bool match = true;

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(input[i]);
                        break;

                    case ')':
                        if (stack.Any() == false)
                        {
                            match = false;
                        }

                        else if (stack.Pop() != '(')
                        {
                            match = false;
                        }
                        break;

                    case ']':
                        if (stack.Any() == false)
                        {
                            match = false;
                        }

                        else if (stack.Pop() != '[')
                        {
                            match = false;
                        }
                        break;

                    case '}':
                        if (stack.Any() == false)
                        {
                            match = false;
                        }

                        else if (stack.Pop() != '{')
                        {
                            match = false;
                        }
                        break;
                }

                if (match == false)
                {
                    break;
                }
            }

            Console.WriteLine(match ? "YES" : "NO");
        }
    }
}

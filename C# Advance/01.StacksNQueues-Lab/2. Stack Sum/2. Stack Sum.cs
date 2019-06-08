using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split();

                var command = tokens[0].ToLower();
                
                if (command == "add")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        var num = int.Parse(tokens[i]);
                        stack.Push(num);
                    }
                }

                else if(command == "remove")
                {
                    var countOfRemoveNums = int.Parse(tokens[1]);

                    if (stack.Count < countOfRemoveNums)
                    {
                        commandInfo = Console.ReadLine().ToLower();

                        continue;
                    }

                    for (int i = 0; i < countOfRemoveNums; i++)
                    {
                        stack.Pop();
                    }
                }

                commandInfo = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

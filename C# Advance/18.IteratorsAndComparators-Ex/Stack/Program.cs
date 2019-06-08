namespace Stack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new CustomStack<int>();

            while (input != "END")
            {
                var splitedInput = input
                    .Split(" ", 2);

                var command = splitedInput[0];

                if (command == "Push")
                {
                    var numbers = splitedInput[1]
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray();

                    stack.Push(numbers);
                }

                
                else
                {
                    try
                    {
                        stack.Pop();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var number in stack)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
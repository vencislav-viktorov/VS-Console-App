namespace ListyIterator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            ListyIterator<string> listyIterator = null;

            while (input != "END")
            {
                var splitedInput = input
                    .Split();
                var command = splitedInput[0];

                if (command == "Create")
                {
                    listyIterator = new ListyIterator<string>(splitedInput
                        .Skip(1)
                        .ToList());
                }
                
                else if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }

                else if (command == "Print")
                {
                    Console.WriteLine(listyIterator.Print());
                }

                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                
                input = Console.ReadLine();
            }
        }
    }
}

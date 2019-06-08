using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Supermarket
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            int countNotPaid = 0;

            while (input != "End")
            {
                if (input == "Paid")
                {
                    int namesCount = names.Count;

                    for (int i = 0; i < namesCount; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                        countNotPaid = 0;
                }

                else
                {
                    names.Enqueue(input);
                    countNotPaid++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{countNotPaid} people remaining.");
        }
    }
}

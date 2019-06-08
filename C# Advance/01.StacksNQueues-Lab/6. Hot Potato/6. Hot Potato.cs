using System;
using System.Collections.Generic;

namespace _6._Hot_Potato
{
    public class Program
    {
        public static void Main()
        {
            var allChildren = Console.ReadLine().Split();

            Queue<string> children = new Queue<string>(allChildren);

            var number = int.Parse(Console.ReadLine());

            int count = 1;

            while (children.Count > 1)
            {
                var currentChild = children.Dequeue();

                if (count % number != 0)
                {
                    children.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }

                count++;
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}

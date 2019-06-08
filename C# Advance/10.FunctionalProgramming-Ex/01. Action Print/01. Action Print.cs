using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}

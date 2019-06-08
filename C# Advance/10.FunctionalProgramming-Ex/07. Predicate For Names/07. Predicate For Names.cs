using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main()
        {
            int maxLength = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(Environment.NewLine,
                              Console.ReadLine()
                              .Split()
                              .Where(x => x.Length <= maxLength)));
        }
    }
}
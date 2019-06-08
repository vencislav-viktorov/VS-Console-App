using System;
using System.Linq;

namespace _03._CountUppercaseWords
{
    class Program
    {
        static void Main()
       => Console.ReadLine()
                .Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .ToList()
                .ForEach(Console.WriteLine);
    }
}

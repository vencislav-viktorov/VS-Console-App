using System;
using System.Linq;

namespace _03._Word_Filter_3rdway
{
    class Program
    {
        static void Main()
            => Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
    }
}

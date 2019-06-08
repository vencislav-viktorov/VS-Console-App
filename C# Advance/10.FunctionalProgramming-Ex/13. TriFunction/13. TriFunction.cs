using System;
using System.Linq;

namespace _13._TriFunction
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split();

            Console.WriteLine(names.FirstOrDefault(n => (n.ToCharArray()
                                                          .Sum(c => (int)c)) >= num));
        }
    }
}
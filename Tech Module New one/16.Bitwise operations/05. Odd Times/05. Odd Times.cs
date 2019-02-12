using System;
using System.Linq;

namespace _05._Odd_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numbers = input.Split().Select(int.Parse);

            int result = 0;

            foreach (var number in numbers)
            {
                result ^= number;
            }

            Console.WriteLine(result);
        }
    }
}

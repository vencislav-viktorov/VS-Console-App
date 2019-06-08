using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main()
        {
            var prices = Console.ReadLine()
                .Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).Select(n => n * 1.2)
                .ToList();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
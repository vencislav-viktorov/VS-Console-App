using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            Func<int[], int> getMin = n => n.Min();

            Console.WriteLine(getMin(Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray()));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sort_Numbers
{
    public class Sort_Numbers
    {
        public static void Main()
        {
            List<decimal> lineOfDecimals = Console.ReadLine().Split(' ')
                .Select(decimal.Parse)
                .ToList();

            lineOfDecimals.Sort();

            Console.WriteLine(string.Join(" <= ", lineOfDecimals));
        }
    }
}

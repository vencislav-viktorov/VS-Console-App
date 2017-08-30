﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class Sum_Adjacent_Equal_Numbers
    {
        public static void Main()
        {
            List<decimal> lineOfDigits = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int cycle = 1; cycle < lineOfDigits.Count; cycle++)
            {
                if (lineOfDigits[cycle] == lineOfDigits[cycle - 1])
                {
                    lineOfDigits[cycle] += lineOfDigits[cycle];

                    lineOfDigits.RemoveAt(cycle - 1);

                    cycle = 0;
                }
            }

            Console.WriteLine(string.Join(" ", lineOfDigits));
        }
    }
}

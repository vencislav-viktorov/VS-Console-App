﻿using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int result = (num1 + num2) / num3 * num4;
            Console.WriteLine(result);
        }
    }
}

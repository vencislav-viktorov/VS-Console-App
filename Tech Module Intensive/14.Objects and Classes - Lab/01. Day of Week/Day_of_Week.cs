﻿using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class Day_of_Week
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine($"{date.DayOfWeek}");
        }
    }
}

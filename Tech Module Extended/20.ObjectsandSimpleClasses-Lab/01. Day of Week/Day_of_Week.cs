using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class Day_of_Week
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}

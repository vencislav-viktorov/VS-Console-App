using System;

namespace _01.Day_of_Week
{
    public class Day_of_Week
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(days[day - 1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}

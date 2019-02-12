using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday"
            };

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }

            else
            {
                Console.WriteLine(weekDays[day - 1]);
            }
        }
    }
}

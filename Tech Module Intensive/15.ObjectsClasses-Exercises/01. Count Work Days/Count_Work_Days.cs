using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01.Count_Work_Days
{
    class Date
    {
        public int Month { get; set; }

        public int Day { get; set; }
    }

    public class Count_Work_Days
    {
        public static void Main()
        {
            List<Date> holidays = GetHolidays();

            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime lastDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int countWorkingDays = 0;

            for (DateTime date = firstDate; date <= lastDate; date = date.AddDays(1))
            {
                bool isNonWorkingDay = IsHoliday(date, holidays) ||
                                    date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
                //date.ToString("dddd") == "Saturday" || date.ToString("dddd") == "Sunday";

                if (!isNonWorkingDay) countWorkingDays++;
            }

            Console.WriteLine(countWorkingDays);
        }

        private static bool IsHoliday(DateTime date, List<Date> holidays)
        {
            foreach (Date holiday in holidays)

                if (holiday.Month == date.Month && holiday.Day == date.Day)
                    return true;

            return false;
        }

        private static List<Date> GetHolidays()
        {
            List<Date> holidays = new List<Date>();

            holidays.Add(new Date() { Month = 1, Day = 1 });

            holidays.Add(new Date() { Month = 3, Day = 3 });

            holidays.Add(new Date() { Month = 5, Day = 1 });

            holidays.Add(new Date() { Month = 5, Day = 6 });

            holidays.Add(new Date() { Month = 5, Day = 24 });

            holidays.Add(new Date() { Month = 9, Day = 6 });

            holidays.Add(new Date() { Month = 9, Day = 22 });

            holidays.Add(new Date() { Month = 11, Day = 1 });

            holidays.Add(new Date() { Month = 12, Day = 24 });

            holidays.Add(new Date() { Month = 12, Day = 25 });

            holidays.Add(new Date() { Month = 12, Day = 26 });

            return holidays;
        }
    }
}

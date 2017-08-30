using System;
using System.Globalization;
using System.Linq;

namespace _01.Count_Work_Days_second_way
{
    public class Count_Work_Days_second_way
    {
        public static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holyDays = new DateTime[]
            {
                new DateTime(2000,01,01),

                new DateTime(2000,03,03),

                new DateTime(2000,05,01),

                new DateTime(2000,05,06),

                new DateTime(2000,05,24),

                new DateTime(2000,09,06),

                new DateTime(2000,09,22),

                new DateTime(2000,11,01),

                new DateTime(2000,12,24),

                new DateTime(2000,12,25),

                new DateTime(2000,12,26)
            };

            int counter = 0;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                DateTime tempo = new DateTime(2000, day.Month, day.Day);

                if (!holyDays.Contains(tempo) && day.DayOfWeek != DayOfWeek.Sunday && day.DayOfWeek != DayOfWeek.Saturday)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

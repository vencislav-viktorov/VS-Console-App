using System;

namespace _03.Back_in_30_Minutes_first_way
{
    public class Back_in_30_Minutes_first_way
    {
        public static void Main()
        {
            var hour = int.Parse(Console.ReadLine());

            var minutes = int.Parse(Console.ReadLine());

            TimeSpan span = new TimeSpan(hour, minutes, 0);

            TimeSpan span2 = new TimeSpan(0, 30, 0);

            TimeSpan total = span + span2;

            Console.WriteLine("{0:h\\:mm}", total);
        }
    }
}

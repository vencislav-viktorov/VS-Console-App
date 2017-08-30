using System;

namespace _14.Time_Add_15Minutes_second_way
{
    class Time_Add_15Minutes_second_way
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());

            var min = int.Parse(Console.ReadLine());

            var sum = ((hour * 60) + min + 15);

            var resulthour = sum / 60;

            if (resulthour >= 24)
            {
                resulthour -= 24;
            }

            var resultmin = sum % 60;

            Console.WriteLine("{0}:{1:00}", resulthour, resultmin);
        }
    }
}

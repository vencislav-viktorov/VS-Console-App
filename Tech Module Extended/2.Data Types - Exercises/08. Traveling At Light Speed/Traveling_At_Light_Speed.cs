using System;

namespace _08.Traveling_At_Light_Speed
{
    public class Traveling_At_Light_Speed
    {
        public static void Main()
        {
            decimal lightyears = decimal.Parse(Console.ReadLine());

            decimal kilometres = lightyears * 9450000000000;

            decimal speedofLight = 300000;

            decimal seconds = kilometres / speedofLight;

            decimal minutes = seconds / 60;

            seconds %= 60;

            decimal hours = minutes / 60;

            minutes %= 60;

            decimal days = hours / 24;

            hours %= 24;

            decimal weeks = days / 7;

            days %= 7;

            Console.WriteLine("{0} weeks", (int)weeks);

            Console.WriteLine("{0} days", (int)days);

            Console.WriteLine("{0} hours", (int)hours);

            Console.WriteLine("{0} minutes", (int)minutes);

            Console.WriteLine("{0} seconds", (int)seconds);
        }
    }
}
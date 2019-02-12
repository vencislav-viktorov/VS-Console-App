using System;

namespace _04._Back_In_30_Minutes
{
    public class Program
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            int allMinutes = (hours * 60) + minutes + 30;

            Console.WriteLine($"{allMinutes / 60 % 24}:{allMinutes % 60:d2}");
        }
    }
}

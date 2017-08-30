using System;

namespace _04.Nth_Digit_second_way
{
    public class Nth_Digit_second_way
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int position = int.Parse(Console.ReadLine());

            int lastNDigit = number;

            int lastNCounter = 0;

            for (int i = 0; i < position; i++)
            {
                lastNCounter = number % 10;

                number = number / 10;
            }

            Console.WriteLine(lastNCounter);
        }
    }
}

using System;

namespace _09.Reversed_chars
{
    public class Reversed_chars
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");
        }
    }
}

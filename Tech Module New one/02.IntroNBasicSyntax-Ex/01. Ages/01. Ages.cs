using System;

namespace _01._Ages
{
    public class Program
    {
        public static void Main()
        {
            var age = int.Parse(Console.ReadLine());

            if (age <= 2 && age >= 0)
            {
                Console.WriteLine("baby");
            }

            else if (age <= 13 && age >= 3)
            {
                Console.WriteLine("child");
            }

            else if (age <= 19 && age >= 14)
            {
                Console.WriteLine("teenager");
            }

            else if (age <= 65 && age >= 20)
            {
                Console.WriteLine("adult");
            }

            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}

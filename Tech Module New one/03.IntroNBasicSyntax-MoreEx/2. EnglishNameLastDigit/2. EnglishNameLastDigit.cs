using System;

namespace _2._EnglishNameLastDigit
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0)
            {
                Console.WriteLine("zero");
            }

            else if (number % 10 == 1)
            {
                Console.WriteLine("one");
            }

            else if (number % 10 == 2)
            {
                Console.WriteLine("two");
            }

            else if (number % 10 == 3)
            {
                Console.WriteLine("three");
            }

            else if (number % 10 == 4)
            {
                Console.WriteLine("four");
            }

            else if (number % 10 == 5)
            {
                Console.WriteLine("five");
            }

            else if (number % 10 == 6)
            {
                Console.WriteLine("six");
            }

            else if (number % 10 == 7)
            {
                Console.WriteLine("seven");
            }

            else if (number % 10 == 8)
            {
                Console.WriteLine("eight");
            }

            else if (number % 10 == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}

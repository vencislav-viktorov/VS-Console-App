using System;

namespace _02.Small_Shop
{
    class Small_Shop
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();

            var city = Console.ReadLine().ToLower();

            var quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(0.5 * quantity);
                }

                else if (city == "plovdiv")
                {
                    Console.WriteLine(0.4 * quantity);
                }

                else if (city == "varna")
                {
                    Console.WriteLine(0.45 * quantity);
                }
            }

            if (product == "water")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(0.8 * quantity);
                }

                else if (city == "plovdiv")
                {
                    Console.WriteLine(0.7 * quantity);
                }

                else if (city == "varna")
                {
                    Console.WriteLine(0.7 * quantity);
                }
            }

            if (product == "beer")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(1.2 * quantity);
                }

                else if (city == "plovdiv")
                {
                    Console.WriteLine(1.15 * quantity);
                }

                else if (city == "varna")
                {
                    Console.WriteLine(1.1 * quantity);
                }
            }

            if (product == "peanuts")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(1.6 * quantity);
                }

                else if (city == "plovdiv")
                {
                    Console.WriteLine(1.5 * quantity);
                }

                else if (city == "varna")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }

            if (product == "sweets")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(1.45 * quantity);
                }

                else if (city == "plovdiv")
                {
                    Console.WriteLine(1.3 * quantity);
                }

                else if (city == "varna")
                {
                    Console.WriteLine(1.35 * quantity);
                }
            }
        }
    }
}

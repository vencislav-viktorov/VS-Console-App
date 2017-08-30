using System;

namespace _07.Fruit_Shop
{
    class Fruit_Shop
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();

            var day = Console.ReadLine().ToLower();

            var quantity = double.Parse(Console.ReadLine());
            
            if (day == "monday" || day == "tuesday" || day == "wednesday"
                || day == "thursday" || day == "friday")
            {
                if (product == "banana")
                {
                    Console.WriteLine("{0:F2}", 2.5 * quantity);
                }

                else if (product == "apple")
                {
                    Console.WriteLine("{0:F2}", 1.2 * quantity);
                }

                else if (product == "orange")
                {
                    Console.WriteLine("{0:F2}", 0.85 * quantity);
                }

                else if (product == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", 1.45 * quantity);
                }

                else if (product == "kiwi")
                {
                    Console.WriteLine("{0:F2}", 2.7 * quantity);
                }

                else if (product == "grapes")
                {
                    Console.WriteLine("{0:F2}", 3.85 * quantity);
                }

                else if (product == "pineapple")
                {
                    Console.WriteLine("{0:F2}", 5.5 * quantity);
                }
            }

            if (day == "sunday" || day == "saturday")
            {
                if (product == "banana")
                {
                    Console.WriteLine("{0:F2}", 2.7 * quantity);
                }

                else if (product == "apple")
                {
                    Console.WriteLine("{0:F2}", 1.25 * quantity);
                }

                else if (product == "orange")
                {
                    Console.WriteLine("{0:F2}", 0.9 * quantity);
                }

                else if (product == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", 1.6 * quantity);
                }

                else if (product == "kiwi")
                {
                    Console.WriteLine("{0:F2}", 3.0 * quantity);
                }

                else if (product == "grapes")
                {
                    Console.WriteLine("{0:F2}", 4.2 * quantity);
                }

                else if (product == "pineapple")
                {
                    Console.WriteLine("{0:F2}", 5.6 * quantity);
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

using System;

namespace _03.Restaurant_Discount
{
    public class Restaurant_Discount
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());

            var package = Console.ReadLine();

            double price = 0.0;

            if (groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");

                if (package == "Normal")
                {
                    price = 2500 + 500 - ((2500 + 500) * 0.05);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }

                else if (package == "Gold")
                {
                    price = 2500 + 750 - ((2500 + 750) * 0.10);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }

                else if (package == "Platinum")
                {
                    price = 2500 + 1000 - ((2500 + 1000) * 0.15);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }

            else if (groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");

                if (package == "Normal")
                {
                    price = 5000 + 500 - ((5000 + 500) * 0.05);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }

                else if (package == "Gold")
                {
                    price = 5000 + 750 - ((5000 + 750) * 0.10);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }

                else if (package == "Platinum")
                {
                    price = 5000 + 1000 - ((5000 + 1000) * 0.15);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }

            else if (groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");

                if (package == "Normal")
                {
                    price = 7500 + 500 - ((7500 + 500) * 0.05);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }

                else if (package == "Gold")
                {
                    price = 7500 + 750 - ((7500 + 750) * 0.10);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }

                else if (package == "Platinum")
                {
                    price = 7500 + 1000 - ((7500 + 1000) * 0.15);

                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
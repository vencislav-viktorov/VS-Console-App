using System;

namespace _03._Vacation
{
    public class Program
    {
        public static void Main()
        {
            var groupCount = double.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerNight = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerNight = 8.45 * groupCount;
                }

                else if (dayOfWeek == "Saturday")
                {
                    pricePerNight = 9.8 * groupCount;
                }

                else
                {
                    pricePerNight = 10.46 * groupCount;
                }

                if (groupCount >= 30)
                {
                    pricePerNight *= 0.85;
                }
            }

            if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerNight = 10.9 * groupCount;

                    if (groupCount >= 100)
                    {
                        pricePerNight -= 109;
                    }
                }

                else if (dayOfWeek == "Saturday")
                {
                    pricePerNight = 15.6 * groupCount;

                    if (groupCount >= 100)
                    {
                        pricePerNight -= 156;
                    }
                }

                else
                {
                    pricePerNight = 16 * groupCount;

                    if (groupCount >= 100)
                    {
                        pricePerNight -= 160;
                    }
                }
            }

            if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerNight = 15 * groupCount;
                }

                else if (dayOfWeek == "Saturday")
                {
                    pricePerNight = 20 * groupCount;
                }

                else
                {
                    pricePerNight = 22.5 * groupCount;
                }

                if (groupCount >= 10 && groupCount <= 20)
                {
                    pricePerNight *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {pricePerNight:f2}");
        }
    }
}

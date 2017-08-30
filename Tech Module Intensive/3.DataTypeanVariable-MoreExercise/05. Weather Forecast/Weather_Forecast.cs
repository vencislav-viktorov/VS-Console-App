using System;

namespace _05.Weather_Forecast
{
    public class Weather_Forecast
    {
        public static void Main()
        {
            try
            {
                long weather = long.Parse(Console.ReadLine());

                if (weather >= sbyte.MinValue && weather <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }

                else if (weather >= int.MinValue && weather <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }

                else
                {
                    Console.WriteLine("Windy");
                }
                
            }

            catch
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}

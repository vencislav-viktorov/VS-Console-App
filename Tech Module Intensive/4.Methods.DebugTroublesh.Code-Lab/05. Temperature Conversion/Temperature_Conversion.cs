using System;

namespace _05.Temperature_Conversion
{
    public class Temperature_Conversion
    {
        public static void Main()
        {
            var fahrenheit = double.Parse(Console.ReadLine());

            var celsius = FahrenheitToCelsius(fahrenheit);

            Console.WriteLine("{0:f2}", celsius);
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

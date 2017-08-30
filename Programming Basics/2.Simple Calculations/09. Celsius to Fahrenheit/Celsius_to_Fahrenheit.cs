using System;

namespace _09.Celsius_to_Fahrenheit
{
    class Celsius_to_Fahrenheit
    {
        static void Main()
        {
            Console.Write("Celsius = ");

            var Celsius = double.Parse(Console.ReadLine());

            var Fahrenheit = ((Celsius * 9 / 5) + 32);

            Console.Write("Fahrenheit = ");

            Console.WriteLine(Fahrenheit);
        }
    }
}

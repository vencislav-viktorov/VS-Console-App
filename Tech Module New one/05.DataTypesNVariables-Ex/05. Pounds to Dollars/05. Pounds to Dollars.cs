using System;

namespace _05._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPound = double.Parse(Console.ReadLine());

            double convertToDollars = britishPound * 1.31;
            Console.WriteLine($"{convertToDollars:f3}");
        }
    }
}

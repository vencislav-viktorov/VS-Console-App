using System;

namespace _04.Beverage_Labels
{
    public class Beverage_Labels
    {
        public static void Main()
        {
            string Name = Console.ReadLine();

            double Volume = double.Parse(Console.ReadLine());

            double Energycontent = double.Parse(Console.ReadLine());

            double Sugarcontent = double.Parse(Console.ReadLine());

            double energyall = Energycontent * (Volume / 100);

            double sugarall = Sugarcontent * (Volume / 100);

            Console.WriteLine($"{Volume}ml {Name}:");

            Console.WriteLine($"{energyall}kcal, {sugarall}g sugars");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Vehicle_Catalogue_second_way
{
    public class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            while (true)
            {
                var line = Console.ReadLine().Split();

                if (line[0] == "End")
                    break;

                var vehicle = new Vehicle();

                var letter = line[0].First().ToString().ToUpper();

                vehicle.Type = letter + line[0].Remove(0, 1).ToLower();

                vehicle.Model = line[1];

                vehicle.Color = line[2];

                vehicle.Horsepower = int.Parse(line[3]);

                vehicles.Add(vehicle);
            }

            while (true)
            {
                var model = Console.ReadLine();

                if (model == "Close the Catalogue")
                    break;

                var car = vehicles.Where(x => x.Model == model)
                    .ToList();

                foreach (var item in car)
                {
                    Console.WriteLine($"Type: {item.Type}");

                    Console.WriteLine($"Model: {item.Model}");

                    Console.WriteLine($"Color: {item.Color}");

                    Console.WriteLine($"Horsepower: {item.Horsepower}");
                }
            }

            double carsSum = vehicles.Where(x => x.Type == "Car").Sum(x => x.Horsepower);

            double trucksSum = vehicles.Where(x => x.Type == "Truck").Sum(x => x.Horsepower);

            double carsCount = vehicles.Where(x => x.Type == "Car").Count();

            double trucksCount = vehicles.Where(x => x.Type == "Truck").Count();

            Console.Write($"Cars have average horsepower of: ");

            if (carsCount == 0)
                Console.WriteLine($"{0:f2}.");

            else
                Console.WriteLine($"{carsSum / carsCount:f2}.");
            Console.Write($"Trucks have average horsepower of: ");

            if (trucksCount == 0)
                Console.WriteLine($"{0:f2}.");

            else
                Console.WriteLine($"{trucksSum / trucksCount:f2}.");

        }
    }
}

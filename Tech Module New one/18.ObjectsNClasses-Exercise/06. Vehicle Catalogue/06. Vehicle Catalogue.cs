using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] splitedInput = input.Split();

                string type = splitedInput[0];

                if (type == "car")
                {
                    type = "Car";
                }

                if (type == "truck")
                {
                    type = "Truck";
                }

                string model = splitedInput[1];

                string colour = splitedInput[2];

                int horsePower = int.Parse(splitedInput[3]);

                Vehicles vehicle = new Vehicles(type, model, colour, horsePower);

                vehicles.Add(vehicle);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                var vehicle = vehicles.Where(x => x.Model == input).First();

                Console.WriteLine($"Type: {vehicle.Type}");

                Console.WriteLine($"Model: {vehicle.Model}");

                Console.WriteLine($"Color: {vehicle.Colour}");

                Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
            }

            var cars = vehicles.Where(x => x.Type == "Car").ToList();

            var trucks = vehicles.Where(x => x.Type == "Truck").ToList();

            if (cars.Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of:" +
                    $" {cars.Select(x => x.HorsePower).Average():F2}.");
            }

            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of:" +
                    $" {trucks.Select(x => x.HorsePower).Average():F2}.");
            }

            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            var trucks = new List<Trucks>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split('/');

                if (commands[0] == "end")
                {
                    break;
                }

                string type = commands[0];

                string brand = commands[1];

                string model = commands[2];

                switch (type)
                {
                    case "Car":
                        string hp = commands[3];
                        var currentCar = new Car(type, brand, model, hp);
                        cars.Add(currentCar);
                        break;

                    case "Truck":
                        string weight = commands[3];
                        var currentTrucks = new Trucks(type, brand, model, weight);
                        trucks.Add(currentTrucks);
                        break;
                }
            }

            var catalogue = new CatalogueVehicle(cars, trucks);

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (var vehicle in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var vehicle in catalogue.Trucks.OrderBy(X => X.Brand))
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.Weight}kg");
                }
            }
        }
    }
}

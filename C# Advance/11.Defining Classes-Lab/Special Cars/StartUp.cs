namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] fourTires = new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),
                };

                tires.Add(fourTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int engineHorsePower = int.Parse(tokens[0]);
                double engineCubicCapacity = double.Parse(tokens[1]);
                Engine engine = new Engine(engineHorsePower, engineCubicCapacity);
                engines.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                cars.Add(car);

                input = Console.ReadLine();
            }

            List<Car> filteredCars = cars
                .FindAll(x => x.Year >= 2017 &&
                x.Engine.HorsePower > 330 &&
                x.Tires.Select(y => y.Pressure).Sum() > 9 &&
                x.Tires.Select(y => y.Pressure).Sum() < 10).ToList();

            for (int i = 0; i < filteredCars.Count; i++)
            {
                filteredCars[i].Drive(20);
            }

            foreach (var specialCar in filteredCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
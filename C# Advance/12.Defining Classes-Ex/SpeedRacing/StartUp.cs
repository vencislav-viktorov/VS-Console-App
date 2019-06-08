namespace DefinintgClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
               var currentCarInfo = Console.ReadLine()
                    .Split();

                var car = currentCarInfo[0];
                var fuelAmount = double.Parse(currentCarInfo[1]);
                var fuelConsumptionPerKM = double.Parse(currentCarInfo[2]);

                cars.Add(new Car(car, fuelAmount, fuelConsumptionPerKM));
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command
                    .Split();
                var carAndModel = tokens[1];
                var km = int.Parse(tokens[2]);

                cars
                    .Find(c => c.Model == carAndModel)
                    .Drive(km);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledKM}");
            }
        }
    }
}
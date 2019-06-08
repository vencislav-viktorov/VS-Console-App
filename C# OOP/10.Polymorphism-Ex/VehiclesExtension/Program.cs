namespace VehiclesExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            for (int i = 1; i <= 3; i++)
            {
                var vehicleArgs = Console.ReadLine()
                   .Split();

                var fuelQuantity = double.Parse(vehicleArgs[1]);
                var fuelConsumption = double.Parse(vehicleArgs[2]);
                var tankCapacity = int.Parse(vehicleArgs[3]);

                Vehicle vehicle = null;

                if (i == 1)
                {
                    vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }

                else if (i == 2)
                {
                    vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }

                else
                {
                    vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                }

                vehicles.Add(vehicle);
            }

            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var commandsArgs = Console.ReadLine()
                    .Split();

                var command = commandsArgs[0];
                var commandType = commandsArgs[1];

                if (command == "Drive")
                {
                    var distance = double.Parse(commandsArgs[2]);

                    var currentVehicle = vehicles
                        .FirstOrDefault(x => x.GetType().Name == commandType);

                    Console.WriteLine(currentVehicle.Drive(distance));
                }

                else if (command == "Refuel")
                {
                    var fuelAmount = double.Parse(commandsArgs[2]);

                    var currentVehicle = vehicles
                    .FirstOrDefault(x => x.GetType().Name == commandType);


                    try
                    {
                        currentVehicle.Refuel(fuelAmount);
                    }

                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                else
                {
                    var distance = double.Parse(commandsArgs[2]);

                    Bus currentBus = (Bus)vehicles
                        .FirstOrDefault(x => x.GetType().Name == commandType);
                    
                    Console.WriteLine(currentBus.DriveEmpty(distance));
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
namespace Vehicles
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var carArgs = Console.ReadLine()
                .Split();
            var carFuelQuantity = double.Parse(carArgs[1]);
            var carFuelConsumption = double.Parse(carArgs[2]);
            var car = new Car(carFuelQuantity, carFuelConsumption);

            var truckArgs = Console.ReadLine()
                .Split();
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);
            var truck = new Truck(truckFuelQuantity, truckFuelConsumption);

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

                    if (commandType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }

                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }

                else
                {
                    var fuelAmount = double.Parse(commandsArgs[2]);

                    if (commandType == "Car")
                    {
                        car.Refuel(fuelAmount);
                    }

                    else
                    {
                        truck.Refuel(fuelAmount);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
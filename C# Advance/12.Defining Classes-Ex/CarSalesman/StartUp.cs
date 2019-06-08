namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var engines = new List<Engine>();

            var numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int displacement))
                    {
                        engines.Add(new Engine(model, power, displacement));
                    }

                    else
                    {
                        var efficiency = engineInfo[2];

                        engines.Add(new Engine(model, power, efficiency));
                    }
                }

                else if (engineInfo.Length == 4)
                {
                    var displacement = int.Parse(engineInfo[2]);
                    var efficiency = engineInfo[3];
                    
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }

                else
                {
                    engines.Add(new Engine(model, power));
                }
            }

            var cars = new List<Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var currentCarEngine = engines
                    .Find(e => e.Model == carInfo[1]);
                var model = carInfo[0];

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int weight))
                    {
                        cars.Add(new Car(model, currentCarEngine, weight));
                    }

                    else
                    {
                        var color = carInfo[2];

                        cars.Add(new Car(model, currentCarEngine, color));
                    }
                }
                else if (carInfo.Length == 4)
                {
                    var weight = int.Parse(carInfo[2]);
                    var color = carInfo[3];

                    cars.Add(new Car(model, currentCarEngine, weight, color));
                }

                else
                {
                    cars.Add(new Car(model, currentCarEngine));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
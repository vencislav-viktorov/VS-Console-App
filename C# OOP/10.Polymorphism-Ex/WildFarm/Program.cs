using System;

namespace WildFarm
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var animals = new List<Animal>();

            while (input != "End")
            {
                var animalArg = input
                    .Split();

                var animal = AnimalFactory.Create(animalArg);

                var foodArg = Console.ReadLine()
                    .Split();

                var food = FoodFactory.Create(foodArg);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
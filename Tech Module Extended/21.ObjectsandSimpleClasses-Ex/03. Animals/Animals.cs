using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    public class Dog
    {
        public string Class { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Legs { get; set; }

        public static string ProduceSound()
        {
            return "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
        }
    }

    public class Cat
    {
        public string Class { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string IQ { get; set; }

        public static string ProduceSound()
        {
            return "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
        }
    }

    public class Snake
    {
        public string Class { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Cruelty { get; set; }

        public static string ProduceSound()
        {
            return "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
        }
    }

    public class AnimalsTheThrithTask
    {
        public static void Main()
        {
            var dogs = new List<Dog>();

            var cats = new List<Cat>();

            var snakes = new List<Snake>();

            var entered = Console.ReadLine();

            while (entered != "I'm your Huckleberry")
            {
                var parameters = entered.Split(" ".ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                var kind = parameters[0];

                var name = parameters[1];

                var age = string.Empty;

                var property = string.Empty; ;

                if (parameters.Count > 2)
                {
                    age = parameters[2];

                    property = parameters[3];
                }

                if (kind == "Dog")
                {
                    var newDog = new Dog();
                    {
                        newDog.Class = kind;

                        newDog.Name = name;

                        newDog.Age = age;

                        newDog.Legs = property;
                    }

                    dogs.Add(newDog);
                }

                else if (kind == "Cat")
                {
                    var newCat = new Cat();
                    {
                        newCat.Class = kind;

                        newCat.Name = name;

                        newCat.Age = age;

                        newCat.IQ = property;
                    }

                    cats.Add(newCat);
                }

                else if (kind == "Snake")
                {
                    var newSnake = new Snake();
                    {
                        newSnake.Class = kind;

                        newSnake.Name = name;

                        newSnake.Age = age;

                        newSnake.Cruelty = property;
                    }

                    snakes.Add(newSnake);
                }

                else
                {
                    foreach (var item in dogs)
                    {
                        if (item.Name == name)
                        {
                            Console.WriteLine(Dog.ProduceSound());
                        }
                    }

                    foreach (var item in cats)
                    {
                        if (item.Name == name)
                        {
                            Console.WriteLine(Cat.ProduceSound());
                        }
                    }

                    foreach (var item in snakes)
                    {
                        if (item.Name == name)
                        {
                            Console.WriteLine(Snake.ProduceSound());
                        }
                    }
                }

                entered = Console.ReadLine();
            }

            foreach (var item in dogs)
            {
                Console.WriteLine($"{item.Class}: {item.Name}, Age: {item.Age}, Number Of Legs: {item.Legs}");
            }

            foreach (var item in cats)
            {
                Console.WriteLine($"{item.Class}: {item.Name}, Age: {item.Age}, IQ: {item.IQ}");
            }

            foreach (var item in snakes)
            {
                Console.WriteLine($"{item.Class}: {item.Name}, Age: {item.Age}, Cruelty: {item.Cruelty}");
            }
        }
    }
}

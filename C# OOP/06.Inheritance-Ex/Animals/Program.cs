namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var animals = new List<Animal>();

            while (input != "Beast!")
            {
                var typeOfAnimal = input;
                var tokens = Console.ReadLine()
                    .Split();
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var gender = tokens[2];

                try
                {
                    switch (typeOfAnimal)
                    {
                        case "Cat":
                            animals.Add(new Cat(name, age, gender));
                            break;

                        case "Dog":
                            animals.Add(new Dog(name, age, gender));
                            break;

                        case "Frog":
                            animals.Add(new Frog(name, age, gender));
                            break;

                        case "Kitten":
                            animals.Add(new Kitten(name, age, gender));
                            break;

                        case "Tomcat":
                            animals.Add(new Tomcat(name, age, gender));
                            break;

                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            animals.ForEach(a => Console.WriteLine(a));
        }
    }
}
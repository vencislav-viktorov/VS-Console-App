using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] splitedInput = input.Split();

                string name = splitedInput[0];

                string id = splitedInput[1];

                int age = int.Parse(splitedInput[2]);

                Person currentPerson = new Person(name, id, age);

                people.Add(currentPerson);
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}

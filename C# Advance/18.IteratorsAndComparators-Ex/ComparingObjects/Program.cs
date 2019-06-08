namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input != "END")
            {
                var personArgs = input
                    .Split();

                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);
                var town = personArgs[2];
                var person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }

            var personNumber = int.Parse(Console.ReadLine());
            var currentPerson = people[personNumber - 1];
            var equalPeople = 0;
            var notEqualPeople = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (currentPerson.CompareTo(people[i]) == 0)
                {
                    equalPeople++;
                }

                else
                {
                    notEqualPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
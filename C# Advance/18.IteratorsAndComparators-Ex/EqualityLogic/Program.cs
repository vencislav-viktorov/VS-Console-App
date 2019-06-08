namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var hashPeople = new HashSet<Person>();
            var sortedPeople = new SortedSet<Person>();
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var personArgs = Console.ReadLine()
                    .Split();

                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);
                var person = new Person(name, age);

                hashPeople.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
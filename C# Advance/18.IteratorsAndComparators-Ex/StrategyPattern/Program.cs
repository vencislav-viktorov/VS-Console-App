namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());
            var setByName = 
                new SortedSet<Person>(new PersonNameLengthComparer());
            var setByAge = 
                new SortedSet<Person>(new PersonAgeComparer());

            for (int i = 0; i < linesCount; i++)
            {
                var personArg = Console.ReadLine()
                    .Split();

                var name = personArg[0];
                var age = int.Parse(personArg[1]);
                var person = new Person(name, age);

                setByName.Add(person);
                setByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, setByName));
            Console.WriteLine(string.Join(Environment.NewLine, setByAge));
        }
    }
}
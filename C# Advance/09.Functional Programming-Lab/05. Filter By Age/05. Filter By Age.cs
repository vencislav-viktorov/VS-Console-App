﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int totalPeople = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < totalPeople; i++)
            {
                var currentPerson = Console.ReadLine()
                    .Split(new[] { ',', ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                var person = new Person
                {
                    Name = currentPerson[0],
                    Age = int.Parse(currentPerson[1])
                };

                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;

            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            string format = Console.ReadLine();

            Func<Person, string> SelectFunc;

            if (format == "name age")
            {
                SelectFunc = p => $"{p.Name} - {p.Age}";
            }
            else if (format == "age")
            {
                SelectFunc = p => $"{p.Age}";
            }
            else
            {
                SelectFunc = p => $"{p.Name}";
            }

            people
                .Where(filterPredicate)
                .Select(SelectFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}

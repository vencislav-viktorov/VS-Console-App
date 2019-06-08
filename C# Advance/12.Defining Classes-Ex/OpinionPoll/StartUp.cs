namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var memberCount = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < memberCount; i++)
            {
                var personArgs = Console.ReadLine()
                    .Split();

                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            List<Person> peopleOverThirty = family
                .GetPeopleOverThirty()
                .OrderBy(x => x.Name)
                .ToList();
            Console.WriteLine(string.Join(Environment.NewLine, peopleOverThirty));
        }
    }
}
namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var birthdayList = new List<IBirthable>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input
                    .Split();

                switch (tokens[0])
                {
                    case "Citizen":
                        var name = tokens[1];
                        var age = int.Parse(tokens[2]);
                        var id = tokens[3];
                        var birthdate = tokens[4];

                        birthdayList.Add(new Citizen(
                            name,
                            age,
                            id,
                            birthdate));
                        break;

                    case "Pet":
                        name = tokens[1];
                        birthdate = tokens[2];

                        birthdayList.Add(new Pet(
                            name,
                            birthdate));
                        break;
                }

                input = Console.ReadLine();
            }

            int year = int.Parse(Console.ReadLine());

            birthdayList
                .Where(c => c.Birthdate.Year == year)
                .Select(c => c.Birthdate)
                .ToList()
                .ForEach(dt => Console.WriteLine($"{dt:dd/mm/yyyy}"));
        }
    }
}
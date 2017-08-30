using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Order_by_Age
{
    public class User
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, User>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                    break;

                var input = line.Split();

                var user = new User();

                user.Name = input[0];

                user.ID = input[1];

                user.Age = int.Parse(input[2]);

                data[input[1]] = user;
            }

            foreach (var item in data.Values.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} " +
                    $"is {item.Age} years old.");
            }
        }

    }
}

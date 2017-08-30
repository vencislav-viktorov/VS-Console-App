using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.Register_Users
{
    public class Register_Users
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var register = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>' }, 
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = tokens[0];

                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", 
                    CultureInfo.InvariantCulture);


                if (!register.ContainsKey(name))
                {
                    register[name] = default(DateTime);
                }

                register[name] = date;

                input = Console.ReadLine();
            }

            var lastFiveUser = register
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var user in lastFiveUser)
            {
                Console.WriteLine($"{user.Key}");
            }
        }
    }
}

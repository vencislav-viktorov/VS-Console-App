using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Dictionary<string, List<string>> companyNameAndIds = new Dictionary<string, List<string>>();

            while (line != "End")
            {
                string[] tokens = line
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string companyName = tokens[0];

                string idUser = tokens[1];

                if (!companyNameAndIds.ContainsKey(companyName))
                {
                    companyNameAndIds[companyName] = new List<string>();
                }

                if (!companyNameAndIds[companyName].Contains(idUser))
                {
                    companyNameAndIds[companyName].Add(idUser);
                }


                line = Console.ReadLine();
            }

            foreach (var kvp in companyNameAndIds.OrderBy(x => x.Key))
            {
                string companyName = kvp.Key;
                List<string> countOdIds = kvp.Value;

                Console.WriteLine($"{companyName}");

                foreach (var id in countOdIds)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}

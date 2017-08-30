using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    public class Website
    {
        public string Host { get; set; }

        public string Domane { get; set; }

        public List<string> Queries { get; set; }
    }

    public class Websites
    {
        public static void Main()
        {
            var entered = Console.ReadLine();

            var webSites = new List<Website>();

            var parameters = new List<string>();

            while (entered != "end")
            {
                parameters = entered.Split("| ,".ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                var newSite = new Website();
                {
                    newSite.Host = parameters[0];

                    newSite.Domane = parameters[1];

                    newSite.Queries = parameters.Skip(2).ToList();
                }

                webSites.Add(newSite);

                entered = Console.ReadLine();
            }

            foreach (var site in webSites)
            {
                Console.Write($"https://www.{site.Host}.{site.Domane}");

                Console.WriteLine(site.Queries.Count > 0 ? $"/query?=[{string.Join("]&[", site.Queries)}]" : string.Empty);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07._Nether_Realms
{
    class Program
    {
        public class Demon
        {
            public string Name { get; set; }
            public long Healt { get; set; }
            public double Damage { get; set; }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            Regex healtRegex = new Regex(@"[^0-9\.+\-*\/]");

            Regex damageRegex = new Regex(@"[-]?[0-9]+(\.[0-9]+)?");

            List<Demon> demonList = new List<Demon>();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();

                StringBuilder sb = new StringBuilder();

                for (int s = 0; s < input[i].Length; s++)
                {
                    if (input[i][s] != ' ' && input[i][s] != ',')
                    {
                        sb.Append(input[i][s]);
                    }
                }

                long healt = 0;

                double baseDamage = 0;

                var matchHealtSymbol = healtRegex.Matches(sb.ToString());

                foreach (var symbol in matchHealtSymbol)
                {
                    healt += char.Parse(symbol.ToString());
                }

                var matchDamageNumber = damageRegex.Matches(sb.ToString());

                foreach (var number in matchDamageNumber)
                {
                    baseDamage += double.Parse(number.ToString());
                }

                if (baseDamage != 0)
                {
                    for (int k = 0; k < sb.ToString().Length; k++)
                    {
                        if (sb.ToString()[k] == '*')
                        {
                            baseDamage *= 2;
                        }

                        else if (sb.ToString()[k] == '/')
                        {
                            baseDamage /= 2;
                        }
                    }
                }

                Demon demon = new Demon()
                {
                    Name = sb.ToString(),
                    Healt = healt,
                    Damage = baseDamage
                };

                demonList.Add(demon);
            }

            foreach (var demon in demonList.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Healt} health, {demon.Damage:F2} damage");
            }
        }
    }
}

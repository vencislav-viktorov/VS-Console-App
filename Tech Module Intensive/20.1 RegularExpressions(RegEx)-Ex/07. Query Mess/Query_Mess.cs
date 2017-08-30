using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.Query_Mess
{
    public class Query_Mess
    {
        public static void Main()
        {
            var result = new StringBuilder();

            var command = Console.ReadLine();

            while (command != "END")
            {
                var line = Regex.Split(command, @"[&\?]")
                .Where(x => Regex.IsMatch(x, @"="))
                .Select(x => Regex.Replace(x, @"(%20|\+)+", " "))
                .Select(x => Regex.Replace(x, @"^ ?(.*?) ?= ?(.*?) ?$", @"$1=$2"))
                .ToList();

                var pairs = new List<Pairs>();

                foreach (var kvp in line)
                {
                    var kvpValues = kvp.Split('=').ToList();

                    var index = pairs.FindIndex(x => x.Key == kvpValues[0]);

                    if (index >= 0)
                    {
                        pairs[index].Value.Add(kvpValues[1]);

                        continue;
                    }

                    pairs.Add(new Pairs() { Key = kvpValues[0], Value = new List<string>() { kvpValues[1] } });
                }

                foreach (var pair in pairs)
                {
                    result.Append(pair);
                }

                result.Append("\r\n");

                command = Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }

    internal class Pairs
    {
        public string Key { get; set; }

        public List<string> Value { get; set; }

        public override string ToString()
        {
            return Key + "=[" + string.Join(", ", Value) + "]";
        }
    }
}
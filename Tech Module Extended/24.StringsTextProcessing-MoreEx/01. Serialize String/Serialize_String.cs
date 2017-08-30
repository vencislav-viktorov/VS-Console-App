using System;
using System.Linq;

namespace _01.Serialize_String
{
    public class Serialize_String
    {
        public static void Main()
        {
            var singleInputLine = Console.ReadLine();

            foreach (var singht in singleInputLine.Distinct())
            {
                Console.Write($"{singht}:");

                var result = string.Empty;

                var index = -1;

                foreach (var single in singleInputLine)
                {
                    index++;

                    if (singht == single) { result += index + "/"; }
                }

                index = -1;

                Console.WriteLine(result.Trim('/'));

                result = string.Empty;
            }
        }
    }
}

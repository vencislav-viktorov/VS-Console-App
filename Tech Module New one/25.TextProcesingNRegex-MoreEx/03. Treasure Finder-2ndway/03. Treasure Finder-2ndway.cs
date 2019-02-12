using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Regex typeRegex = new Regex(@"[&][A-Za-z]+[&]");

            Regex coordinateRegex = new Regex(@"[<][A-Za-z0-9]+[>]");

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "find")
                {
                    break;
                }

                string result = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    int keyIndex = i % key.Length;

                    var symbol = input[i] - key[keyIndex];

                    char currentChar = (char)symbol;

                    result += currentChar;
                }

                var type = typeRegex.Match(result).ToString();

                var coordinate = coordinateRegex.Match(result).ToString();
                
                if (type.Length != 0 && coordinate.Length != 0)
                {
                    type = type.Substring(1, type.Length - 2);

                    coordinate = coordinate.Substring(1, coordinate.Length - 2);

                    Console.WriteLine($"Found {type} at {coordinate}");
                }
            }
        }
    }
}
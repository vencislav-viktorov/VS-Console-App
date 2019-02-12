using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string input = Console.ReadLine();

                string regexName = @"(?<=@)\w+";
                
                string regexAge = @"(?<=#)\d+";

                MatchCollection names = Regex.Matches(input, regexName);

                MatchCollection ages = Regex.Matches(input, regexAge);

                string nameAsString = string.Empty;

                string ageAsString = string.Empty;

                foreach (Match name in names)
                {
                    nameAsString += name.Value;
                }

                foreach (Match age in ages)
                {
                    ageAsString += age.Value;
                }

                Console.WriteLine($"{nameAsString} is {ageAsString} years old.");
            }
        }
    }
}

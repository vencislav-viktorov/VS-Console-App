using System;
using System.Text.RegularExpressions;

namespace _08._Match_Phone_Number_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();

            string regex = @"\+([359]+)([-| ])2(\2)(\d{3})(\2)(\d{4})\b";

            MatchCollection matcheNumbers = Regex.Matches(phoneNumbers, regex);

            Console.WriteLine(string.Join(", ", matcheNumbers));
        }
    }
}

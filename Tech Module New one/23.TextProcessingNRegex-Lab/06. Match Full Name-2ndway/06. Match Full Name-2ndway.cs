using System;
using System.Text.RegularExpressions;

namespace _06._Match_Full_Name_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection validNames = regex.Matches(names);

            Console.WriteLine(string.Join(" ", validNames));
        }
    }
}

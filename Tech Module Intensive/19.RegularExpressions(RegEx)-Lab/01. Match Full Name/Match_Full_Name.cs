using System;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    public class Match_Full_Name
    {
        public static void Main()
        {
            MatchCollection validNames = Regex.Matches(Console.ReadLine(), @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match name in validNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}

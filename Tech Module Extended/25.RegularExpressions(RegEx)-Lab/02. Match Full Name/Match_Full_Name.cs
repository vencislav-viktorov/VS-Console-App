using System;
using System.Text.RegularExpressions;

namespace _02.Match_Full_Name
{
    public class Match_Full_Name
    {
        public static void Main()
        {
            var pattern = @"\b[A-Z][a-z]+\s{1}\b[A-Z][a-z]+";

            var regex = new Regex(pattern);

            var fullNames = regex.Matches(Console.ReadLine());

            foreach (var name in fullNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _08._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex phoneNumberRegex = new Regex(@"(\+359)( |-)2\2\d{3}\2\d{4}\b");

            MatchCollection validNumbers = phoneNumberRegex.Matches(Console.ReadLine());

            Console.WriteLine(string.Join(", ", validNumbers));
        }
    }
}

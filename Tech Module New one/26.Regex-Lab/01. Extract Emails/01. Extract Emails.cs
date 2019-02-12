﻿using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string regex = @"\s([0-9A-Za-z]+(-*|_*|\.*)[0-9a-zA-Z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";

            MatchCollection matchesEmails = Regex.Matches(message, regex);

            foreach (Match email in matchesEmails)
            {
                Console.WriteLine(email.Groups[1].Value);
            }
        }
    }
}

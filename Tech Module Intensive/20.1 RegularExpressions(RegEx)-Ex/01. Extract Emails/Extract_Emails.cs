using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    public class Extract_Emails
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=\s))(?<mail>[0-9A-Za-z]([0-9A-Za-z_\-\.]*[0-9A-Za-z])?@[0-9A-Za-z]([0-9A-Za-z\-]*[0-9A-Za-z])?(\.[0-9A-Za-z]([0-9A-Za-z\-]*[0-9A-Za-z])?)+)\b";

            var emails = Regex.Matches(Console.ReadLine(), pattern);

            foreach (Match mail in emails)
            {
                Console.WriteLine(mail);
            }
        }
    }
}

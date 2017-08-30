using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    public class Extract_Emails
    {
        public static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.TrimEnd(".,!?".ToCharArray()))
                .ToArray();

            Regex regex = new Regex(@"^[a-zA-Z][\w.-]+@[a-zA-Z-]+(\.[A-Za-z-]+)+$");

            List<string> validEmails = new List<string>();

            foreach (string line in text)
            {
                var matches = regex.Matches(line);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        validEmails.Add(match.Value);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validEmails));
        }
    }
}

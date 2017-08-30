using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Email_Statistics
{
    public class Email_Statistics
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var mails = new Dictionary<string, List<string>>();

            var pattern = @"^(?<user>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.((bg)|(com)|(org)))$";

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var mail = Regex.Match(input, pattern);

                if (mail.Length == 0) continue;

                if (!mails.ContainsKey(mail.Groups["domain"].Value))
                {
                    mails[mail.Groups["domain"].Value] = new List<string>();
                }

                if (!mails[mail.Groups["domain"].Value].Contains(mail.Groups["user"].Value))
                {
                    mails[mail.Groups["domain"].Value].Add(mail.Groups["user"].Value);
                }
            }

            var ordered = mails.OrderByDescending(x => x.Value.Count);

            foreach (var domain in ordered)
            {
                Console.WriteLine(domain.Key + ":");

                foreach (var user in domain.Value)
                {
                    Console.WriteLine("### " + user);
                }
            }
        }
    }
}

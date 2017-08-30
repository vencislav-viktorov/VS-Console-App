using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fix_Emails_second_way
{
    public class Fix_Emails_second_way
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> mailList = new Dictionary<string, string>();

            string[] domains = { ".us", ".uk" };

            string userName = Console.ReadLine();

            while (!userName.Equals("stop"))
            {
                string userMail = Console.ReadLine();

                mailList.Add(userName, userMail);

                userName = Console.ReadLine();
            }

            RemoveEmailsByDomain(mailList, domains);

            foreach (var pair in mailList)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        private static void RemoveEmailsByDomain(Dictionary<string, string> mailList, string[] domains)
        {
            foreach (var domain in domains)
            {
                var filteredEmails = mailList.Where(x => x.Value.EndsWith(domain)).ToList();

                foreach (var userEntry in filteredEmails)
                {
                    mailList.Remove(userEntry.Key);
                }
            }
        }
    }
}

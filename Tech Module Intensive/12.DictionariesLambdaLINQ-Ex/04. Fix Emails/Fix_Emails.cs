using System;
using System.Collections.Generic;

namespace _04.Fix_Emails
{
    public class Fix_Emails
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, string> mailList = new Dictionary<string, string>();

            int counter = 1;

            string key = "";

            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    mailList[input] = "";

                    key = input;
                }

                else
                {
                    mailList[key] = input;
                }

                counter++;

                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, string> pair in mailList)
            {
                if (!pair.Value.ToLower().EndsWith("uk") && !pair.Value.ToLower().EndsWith("us"))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}

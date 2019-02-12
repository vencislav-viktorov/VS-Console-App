using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string username = usernames[i];

                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool validateContent = ValidateUsernameContent(username);

                    if (validateContent)
                    {
                        validUsernames.Add(username);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }

        private static bool ValidateUsernameContent(string username)
        {
            foreach (var symbol in username)
            {
                if (char.IsLetterOrDigit(symbol) == false && symbol != '_' && symbol != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}

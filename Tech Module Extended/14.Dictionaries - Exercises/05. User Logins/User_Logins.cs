using System;
using System.Collections.Generic;

namespace _05.User_Logins
{
    public class User_Logins
    {
        public static void Main()
        {
            var userNameAndPassword = Console.ReadLine();

            var logIn = new Dictionary<string, string>();

            while (userNameAndPassword != "login")
            {
                var input = LogInInformation(userNameAndPassword);

                var userName = input[0];

                var password = input[1];

                if (!logIn.ContainsKey(userName))
                {
                    logIn[userName] = string.Empty;
                }

                logIn[userName] = password;

                userNameAndPassword = Console.ReadLine();
            }

            userNameAndPassword = Console.ReadLine();

            var count = 0;

            while (userNameAndPassword != "end")
            {
                var input = LogInInformation(userNameAndPassword);

                var userName = input[0];

                var password = input[1];

                if (logIn.ContainsKey(userName) && logIn.ContainsValue(password))
                {
                    Console.WriteLine($"{userName}: logged in successfully");
                }

                else
                {
                    Console.WriteLine($"{userName}: login failed");

                    count++;
                }

                userNameAndPassword = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }

        static string[] LogInInformation(string userNameAndPassword)
        {
            return userNameAndPassword
                                .Split(" ->".ToCharArray(),
                                StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

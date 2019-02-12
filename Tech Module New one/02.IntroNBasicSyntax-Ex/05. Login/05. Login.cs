using System;

namespace _05._Login
{
    public class Program
    {
        public static void Main()
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int counter = 1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                else if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                counter++;
            }
        }
    }
}

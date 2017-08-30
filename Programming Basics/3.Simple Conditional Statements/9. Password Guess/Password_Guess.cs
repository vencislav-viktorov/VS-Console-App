using System;

namespace _9.Password_Guess
{
    class Password_Guess
    {
        static void Main()
        {
            var password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

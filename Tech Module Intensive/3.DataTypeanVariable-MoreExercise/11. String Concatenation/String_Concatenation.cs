using System;

namespace _11.String_Concatenation
{
    public class String_Concatenation
    {
        public static void Main()
        {
            char delimeter = char.Parse(Console.ReadLine());

            string condition = Console.ReadLine().ToLower().Trim();

            int n = int.Parse(Console.ReadLine());

            string message = String.Empty;

            int result = 0;

            if (condition == "odd")
            {
                result = 1;
            }

            for (int i = 1; i <= n; i++)
            {
                string tempString = Console.ReadLine();

                if (i % 2 == result)
                {
                    message += tempString + delimeter;
                }
            }

            Console.WriteLine(message.Substring(0, message.Length - 1));
        }
    }
}

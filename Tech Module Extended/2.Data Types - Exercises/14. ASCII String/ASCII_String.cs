using System;

namespace _14.ASCII_String
{
    public class ASCII_String
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int asciCode = int.Parse(Console.ReadLine());

                char character = (char)asciCode;

                result += character;
            }

            Console.WriteLine(result);
        }
    }
}
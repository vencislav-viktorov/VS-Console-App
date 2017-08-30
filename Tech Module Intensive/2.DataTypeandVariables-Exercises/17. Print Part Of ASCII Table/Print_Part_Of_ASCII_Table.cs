using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    public class Print_Part_Of_ASCII_Table
    {
        public static void Main()
        {
            int startChar = int.Parse(Console.ReadLine());

            int endChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}

using System;

namespace _16.Tricky_Strings
{
    public class Tricky_Strings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                result += word + delimiter;
            }

            string removeLastChar = result.Remove(result.Length - delimiter.Length, delimiter.Length);

            Console.WriteLine($"{removeLastChar}");
        }
    }
}
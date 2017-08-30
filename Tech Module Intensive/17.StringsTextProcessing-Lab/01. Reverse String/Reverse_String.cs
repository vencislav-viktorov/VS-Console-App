using System;

namespace _01.Reverse_String
{
    public class Reverse_String
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine(reversed);
        }
    }
}

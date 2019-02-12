using System;

namespace _02._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = String.Empty;

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                text += input;
            }

            Console.WriteLine(text);
        }
    }
}

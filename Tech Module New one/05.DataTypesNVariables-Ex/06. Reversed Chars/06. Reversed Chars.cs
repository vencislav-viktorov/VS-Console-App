using System;
using System.Linq;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = String.Empty;

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();

                text += input + " ";
            }

            string reverseText = new string(text.Reverse().ToArray());
            Console.WriteLine(reverseText.TrimStart());
        }
    }
}

using System;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());

            var secondChar = char.Parse(Console.ReadLine());

            var text = Console.ReadLine().ToCharArray();

            var min = Math.Min(firstChar, secondChar);

            var max = Math.Max(firstChar, secondChar);

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var currentChar = text[i];

                if (currentChar > min && currentChar < max)
                {
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

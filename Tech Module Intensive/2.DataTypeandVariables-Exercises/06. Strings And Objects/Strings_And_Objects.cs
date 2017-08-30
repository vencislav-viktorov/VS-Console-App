using System;

namespace _06.Strings_And_Objects
{
    public class Strings_And_Objects
    {
        public static void Main()
        {
            string firstWord = Console.ReadLine();

            string secondWord = Console.ReadLine();

            object concatenatedStrings = firstWord + " " + secondWord;

            string greeting = (string)concatenatedStrings;

            Console.WriteLine(greeting);
        }
    }
}
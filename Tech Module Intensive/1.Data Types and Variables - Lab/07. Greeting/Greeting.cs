using System;

namespace _07.Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();

            var secondName = Console.ReadLine();

            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {firstName} {secondName}. You are {age} years old.");
        }
    }
}
using System;

namespace _01.Hello__Name_
{
    public class Hello_Name
    {
        public static void Main()
        {
            Console.WriteLine(GreetingGenerator(Console.ReadLine()));
        }

        static string GreetingGenerator(string name)
        {
            string greeting = $"Hello, {name}!";

            return greeting;
        }
    }
}

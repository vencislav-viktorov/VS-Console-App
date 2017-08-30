using System;

namespace _01.Hello__Name_
{
    public class Hello__Name_
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            GreetingByName(name);
        }

        static void GreetingByName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}

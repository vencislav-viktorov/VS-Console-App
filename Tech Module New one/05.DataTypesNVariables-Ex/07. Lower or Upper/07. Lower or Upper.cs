using System;

namespace _07._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char lettet = char.Parse(Console.ReadLine());

            if (lettet >= 'A' && lettet <= 'Z')
            {
                Console.WriteLine("upper-case");
            }

            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main()
        {
            var names = new HashSet<string>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
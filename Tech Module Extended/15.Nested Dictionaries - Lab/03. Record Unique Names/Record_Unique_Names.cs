using System;
using System.Collections.Generic;

namespace _03.Record_Unique_Names
{
    public class Record_Unique_Names
    {
        public static void Main()
        {
            var names = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _03.Record_Unique_Names_secondway
{
    public class Record_Unique_Names_secondway
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                if (!result.Contains(name))
                {
                    result.Add(name);
                }
            }

            foreach (var kvp in result)
            {
                Console.WriteLine(kvp);
            }
        }
    }
}

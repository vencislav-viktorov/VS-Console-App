using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    public class A_Miner_Task
    {
        public static void Main()
        {
            string key = Console.ReadLine();

            Dictionary<string, long> resourses = new Dictionary<string, long>();

            while (key != "stop")
            {
                long value = long.Parse(Console.ReadLine());

                if (!resourses.ContainsKey(key))
                {
                    resourses.Add(key, 0);
                }

                resourses[key] += value;

                key = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> pair in resourses)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

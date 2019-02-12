using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var minerTask = new Dictionary<string, int>();

            while (line != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!minerTask.ContainsKey(line))
                {
                    minerTask[line] = 0;
                }

                minerTask[line] += quantity;
                
                line = Console.ReadLine();
            }

            foreach (var kvp in minerTask)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

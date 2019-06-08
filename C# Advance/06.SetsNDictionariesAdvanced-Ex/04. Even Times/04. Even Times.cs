using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main()
        {
            var line = int.Parse(Console.ReadLine());

            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < line; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(num) == false)
                {
                    numbers.Add(num, 0);
                }

                numbers[num]++;
            }

            Console.WriteLine(numbers.First(x => x.Value % 2 == 0).Key);
        }
    }
}
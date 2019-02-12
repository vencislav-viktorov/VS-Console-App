using System;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            var text = Console.ReadLine().ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] != 0)
                {
                    sum += (numbers[i] % 10);

                    numbers[i] /= 10;
                }

                if (sum > text.Count)
                {
                    sum -= (text.Count);
                }

                Console.Write(text[sum]);

                text.RemoveAt(sum);

                sum = 0;
            }

            Console.WriteLine();

        }
    }
}

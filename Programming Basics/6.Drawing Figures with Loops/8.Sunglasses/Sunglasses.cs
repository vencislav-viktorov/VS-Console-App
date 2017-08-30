using System;

namespace _8.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2),
                                   new string('|', n));
                }

                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2),
                                   new string(' ', n));
                }
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}

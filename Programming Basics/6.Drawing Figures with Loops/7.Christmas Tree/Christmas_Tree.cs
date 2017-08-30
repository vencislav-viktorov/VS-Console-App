using System;

namespace _7.Christmas_Tree
{
    class Christmas_Tree
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n));

            Console.WriteLine(" |");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}", new string(' ', n - i),
                                 new string('*', i));
            }
        }
    }
}

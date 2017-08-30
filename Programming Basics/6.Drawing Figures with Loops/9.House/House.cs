using System;

namespace _9.House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }

            for (int r = 0; r < (n + 1) / 2; r++)
            {
                var d = (n - stars) / 2;

                Console.WriteLine("{0}{1}{0}",
                    new string('-', d), new string('*', stars));

                stars += 2;
            }

            var bodyr = n - (n + 1) / 2;

            for (int r = 0; r < n / 2; r++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}

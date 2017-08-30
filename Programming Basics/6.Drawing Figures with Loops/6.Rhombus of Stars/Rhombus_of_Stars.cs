using System;

namespace _6.Rhombus_of_Stars
{
    class Rhombus_of_Stars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }


            for (int i = n - 1; i > 0; i--)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}

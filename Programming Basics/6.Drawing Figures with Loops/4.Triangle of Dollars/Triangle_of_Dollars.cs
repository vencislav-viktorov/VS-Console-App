using System;

namespace _4.Triangle_of_Dollars
{
    class Triangle_of_Dollars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                for (var c = 1; c <= i; c++)
                {
                    Console.Write("$ ");
                }

                Console.WriteLine();
            }
        }
    }
}

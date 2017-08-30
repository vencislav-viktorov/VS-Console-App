using System;

namespace _3.Square_of_Stars
{
    class Square_of_Stars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write('*');

                for (int c = 1; c < n; c++)
                {
                    Console.Write(" *");

                }
                
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace _2.Rectangle_of_N_x_N_Stars
{
    class Rectangle_of_N_x_N_Stars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}

using System;

namespace _01.Numbers_from1_to_N_with_Step_3
{
    class Numbers_from1_to_N_with_Step_3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

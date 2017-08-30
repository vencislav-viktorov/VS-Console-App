using System;

namespace _05.Sequence_2k_1
{
    class Sequence_2k_1
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);

                num = 2 * num + 1;
            }
        }
    }
}

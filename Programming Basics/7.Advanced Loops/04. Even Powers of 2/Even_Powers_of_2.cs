using System;

namespace _04.Even_Powers_of_2
{
    class Even_Powers_of_2
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int num = 1;

            for (var i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);

                num = num * 2 * 2;
            }
        }
    }
}

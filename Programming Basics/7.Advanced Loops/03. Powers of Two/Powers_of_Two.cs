using System;

namespace _03.Powers_of_Two
{
    class Powers_of_Two
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int num = 1;

            for (var i = 0; i <= n; i++)
            {
                Console.WriteLine(num);

                num = num * 2;
            }
        }
    }
}

using System;

namespace _06.Min_Number
{
    class Min_Number
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var min = int.MaxValue;

            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}

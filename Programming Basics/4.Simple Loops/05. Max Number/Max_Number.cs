using System;

namespace _05.Max_Number
{
    class Max_Number
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var max = int.MinValue;

            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}

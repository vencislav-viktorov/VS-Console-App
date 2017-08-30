using System;

namespace _09.Sum_Digits
{
    class Sum_Digits
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            while (n > 0)
            {
                sum += (n % 10);

                n = n / 10;
            }

            Console.WriteLine("Sum of digits: {0}", sum);
        }
    }
}

using System;

namespace _10._Refactor_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int sumDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumDigits += digits % 10;
                    digits /= 10;
                }

                bool isSpecial = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;

                Console.WriteLine($"{num} -> {isSpecial}");
            }

        }
    }
}

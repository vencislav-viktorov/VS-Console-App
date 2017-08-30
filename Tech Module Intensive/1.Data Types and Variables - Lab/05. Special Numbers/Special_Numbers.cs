using System;

namespace _05.Special_Numbers
{
    public class Special_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;

                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;

                    digits /= 10;
                }

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}

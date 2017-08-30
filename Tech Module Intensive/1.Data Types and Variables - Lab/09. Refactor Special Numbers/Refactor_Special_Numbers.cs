using System;

namespace _09.Refactor_Special_Numbers
{
    public class Refactor_Special_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;

                int currentNum = num;

                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;

                    currentNum = currentNum / 10;
                }

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}

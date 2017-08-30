using System;

namespace _04.Nth_Digit
{
    public class Nth_Digit
    {
        public static void Main()
        {
            int currentNumber = int.Parse(Console.ReadLine());

            int digitIndex = int.Parse(Console.ReadLine());

            int digit = GetDigit(currentNumber, digitIndex);

            Console.WriteLine(digit);
        }

        static int GetDigit(int currentNumber, int digitIndex)
        {
            for (int i = 1; i < digitIndex; i++)
            {
                currentNumber /= 10;
            }

            return currentNumber % 10;
        }
    }
}

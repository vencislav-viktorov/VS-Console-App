using System;

namespace _12.Master_Number
{
    public class Master_Number
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (HasEvenDigitAndSumOfDigitsDivisibleBySeven(i) == true && IsPalindrome(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasEvenDigitAndSumOfDigitsDivisibleBySeven(int n)
        {
            bool hasEvenDigit = false;

            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;

                n /= 10;

                sum += digit;

                if (digit % 2 == 0)
                {
                    hasEvenDigit = true;
                }
            }

            if (sum % 7 == 0 && hasEvenDigit == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool IsPalindrome(int n)
        {
            int inputValue = n;

            string nToString = n.ToString();

            string nStringReversed = String.Empty;

            for (int i = nToString.Length - 1; i >= 0; i--)
            {
                nStringReversed += nToString[i];
            }

            if (inputValue == int.Parse(nStringReversed))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
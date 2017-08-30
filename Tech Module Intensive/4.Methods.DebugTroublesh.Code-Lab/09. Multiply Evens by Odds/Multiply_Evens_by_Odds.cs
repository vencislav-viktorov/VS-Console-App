using System;

namespace _09.Multiply_Evens_by_Odds
{
    public class Multiply_Evens_by_Odds
    {
        public static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine($"{GetMultipleOfEvensAndOdds(n)}");
        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);

            int sumOdds = GetSumOfOddDigits(n);

            return sumEvens * sumOdds;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int lastDigits = n % 10;

                if (lastDigits % 2 != 0)
                {
                    sum += lastDigits;
                }

                n /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int lastDigits = n % 10;

                if (lastDigits % 2 == 0)
                {
                    sum += lastDigits;
                }

                n /= 10;
            }

            return sum;
        }
    }
}

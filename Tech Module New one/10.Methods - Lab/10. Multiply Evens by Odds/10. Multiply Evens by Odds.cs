using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigits = number % 10;

                if (lastDigits % 2 != 0)
                {
                    sum += lastDigits;
                }

                number /= 10;
            }
            
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigits = number % 10;

                if (lastDigits % 2 == 0)
                {
                    sum += lastDigits;
                }

                number /= 10;
            }
            
            return sum;
        }
    }
}

using System;

namespace _08.Multiply_Evens_by_Odds_second_way
{
    public class Multiply_Evens_by_Odds_second_way
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{GetMultipleOfEvensAndOdds(number)}");
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) *
            GetSumOfOddDigits(number));

        }

        static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);

        }

        static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        static int GetSumOfDigits(int number, int remainder)
        {
            var result = 0;

            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';

                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }

            return result;
        }
    }
}
using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintAllNumbersFromOneToNumberWhenSumOfDigitsIsDivisibelByEightAndHaveOneOddDigit(number);
        }

        static void PrintAllNumbersFromOneToNumberWhenSumOfDigitsIsDivisibelByEightAndHaveOneOddDigit(int end)
        {
            for (int i = 8; i < end; i++)
            {
                bool isDivisibleBy8 = CheckIsDivisibleBy8(i);

                bool containsOddNumber = ContainsOddNumber(i);

                if (isDivisibleBy8 && containsOddNumber)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static  bool ContainsOddNumber(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 1)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckIsDivisibleBy8(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                sum += digit;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}

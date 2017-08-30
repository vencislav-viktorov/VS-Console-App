using System;

namespace _03.EnglishNameLastDigitsecondway
{
    public class EnglishNameLastDigitsecondway
    {
        public static void Main()
        {
            long num = Math.Abs(long.Parse(Console.ReadLine()));

            var lastDigit = GetLastDigit(num);

            var lastDigitAsWord = ConvertDigitToWord(lastDigit);

            Console.WriteLine(lastDigitAsWord);
        }

        static string ConvertDigitToWord(long lastDigit)
        {
            string digitAsWord = String.Empty;

            switch (lastDigit)
            {
                case 0:
                    digitAsWord = "zero";
                    break;

                case 1:
                    digitAsWord = "one";
                    break;

                case 2:
                    digitAsWord = "two";
                    break;

                case 3:
                    digitAsWord = "three";
                    break;

                case 4:
                    digitAsWord = "four";
                    break;

                case 5:
                    digitAsWord = "five";
                    break;

                case 6:
                    digitAsWord = "six";
                    break;

                case 7:
                    digitAsWord = "seven";
                    break;

                case 8:
                    digitAsWord = "eight";
                    break;

                case 9:
                    digitAsWord = "nine";
                    break;
            }

            return digitAsWord;
        }

        static long GetLastDigit(long num)
        {
            long lastDigit = num % 10;

            return lastDigit;
        }
    }
}

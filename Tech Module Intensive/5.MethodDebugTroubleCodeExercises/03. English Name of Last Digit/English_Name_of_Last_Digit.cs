using System;

namespace _03.English_Name_of_Last_Digit
{
    public class English_Name_of_Last_Digit
    {
        public static void Main()
        {
            long inputNumber = Math.Abs(long.Parse(Console.ReadLine()));

            Console.WriteLine(GetLastDigitName(inputNumber));
        }

        static string GetLastDigitName(long inputNumber)
        {
            long lastDigit = inputNumber % 10;

            string digitName = String.Empty;

            switch (lastDigit)
            {
                case 0:
                    digitName = "zero";
                    break;

                case 1:
                    digitName = "one";
                    break;

                case 2:
                    digitName = "two";
                    break;

                case 3:
                    digitName = "three";
                    break;

                case 4:
                    digitName = "four";
                    break;

                case 5:
                    digitName = "five";
                    break;

                case 6:
                    digitName = "six";
                    break;

                case 7:
                    digitName = "seven";
                    break;

                case 8:
                    digitName = "eight";
                    break;

                case 9:
                    digitName = "nine";
                    break;
            }

            return digitName;
        }
    }
}

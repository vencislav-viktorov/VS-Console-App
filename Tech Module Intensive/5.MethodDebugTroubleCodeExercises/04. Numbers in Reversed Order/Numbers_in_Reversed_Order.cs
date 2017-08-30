using System;

namespace _04.Numbers_in_Reversed_Order
{
    public class Numbers_in_Reversed_Order
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        static double ReversedNum(double num)
        {
            var numString = num.ToString();

            var reverseString = String.Empty;

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reverseString += numString[i];
            }

            var reverseNum = double.Parse(reverseString);

            return reverseNum;
        }
    }
}

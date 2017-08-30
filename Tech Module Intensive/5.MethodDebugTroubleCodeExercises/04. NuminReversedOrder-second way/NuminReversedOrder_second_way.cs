using System;
using System.Linq;

namespace _04.NuminReversedOrder_second_way
{
    public class NuminReversedOrder_second_way
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        static double ReversedNum(double num)
        {
            var numString = new string(num.ToString().Reverse().ToArray());

            return double.Parse(numString);
        }
    }
}

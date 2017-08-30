using System;

namespace _02.Min_Method
{
    public class Min_Method
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int nextNumber = int.Parse(Console.ReadLine());

            int lastNumber = int.Parse(Console.ReadLine());

            int minNumber = GetMinValue(firstNumber, nextNumber);

            minNumber = GetMinValue(minNumber, lastNumber);

            Console.WriteLine(minNumber);
        }

        static int GetMinValue(int firstNumber, int nextNumber)
        {
            return firstNumber <= nextNumber ? firstNumber : nextNumber;
        }
    }
}

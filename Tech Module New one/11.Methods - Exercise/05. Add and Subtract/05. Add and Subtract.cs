using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int num3 = int.Parse(Console.ReadLine());

            AddTheFirstTwoNumbersNSubtractTheThirdOne(num1, num2, num3);
        }

        static void AddTheFirstTwoNumbersNSubtractTheThirdOne(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 - num3);
        }
    }
}

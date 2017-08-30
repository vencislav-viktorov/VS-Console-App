using System;

namespace _01.Debit_Card_Number
{
    public class Debit_Card_Number
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int num3 = int.Parse(Console.ReadLine());

            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1:D4} {num2:D4} {num3:D4} {num4:D4}");
        }
    }
}

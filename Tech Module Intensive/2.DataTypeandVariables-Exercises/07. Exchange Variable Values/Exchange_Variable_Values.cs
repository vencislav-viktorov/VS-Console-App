using System;

namespace _07.Exchange_Variable_Values
{
    public class Exchange_Variable_Values
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
            
            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondNumber}");
            Console.WriteLine($"b = {firstNumber}");
        }
    }
}

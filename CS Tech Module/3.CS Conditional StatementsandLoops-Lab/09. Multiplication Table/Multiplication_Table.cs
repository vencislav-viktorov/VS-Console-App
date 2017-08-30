using System;

namespace _09.Multiplication_Table
{
    public class Multiplication_Table
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}

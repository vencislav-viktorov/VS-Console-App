using System;

namespace _12.Variable_in_Hexadecimal_Format
{
    public class Variable_in_Hexadecimal_Format
    {
        public static void Main()
        {
            string hex = Console.ReadLine();

            int number = Convert.ToInt32(hex, 16);

            Console.WriteLine(number);
        }
    }
}

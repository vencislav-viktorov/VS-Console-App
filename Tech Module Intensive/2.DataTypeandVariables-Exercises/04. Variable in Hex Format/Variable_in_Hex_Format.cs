using System;

namespace _04.Variable_in_Hex_Format
{
    public class Variable_in_Hex_Format
    {
        public static void Main()
        {
            string hex = Console.ReadLine();

            int number = Convert.ToInt32(hex, 16);

            Console.WriteLine(number);
        }
    }
}
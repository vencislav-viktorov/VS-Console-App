using System;

namespace _14.Integer_to_Hex_and_Binary
{
    public class Integer_to_Hex_and_Binary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 16).ToUpper());  // to Hex

            Console.WriteLine(Convert.ToString(number, 2));             // to Bin
        }
    }
}

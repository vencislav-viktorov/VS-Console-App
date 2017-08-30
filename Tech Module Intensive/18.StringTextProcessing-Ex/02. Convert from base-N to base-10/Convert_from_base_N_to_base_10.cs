using System;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    public class Convert_from_base_N_to_base_10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            long fromBase = long.Parse(input[0]);

            string number = input[1];

            BigInteger result = 0;

            int power = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger num = BigInteger.Parse(number[i].ToString());

                result += BigInteger.Multiply(num, BigInteger.Pow(fromBase, power));

                power--;
            }

            Console.WriteLine(result);
        }
    }
}

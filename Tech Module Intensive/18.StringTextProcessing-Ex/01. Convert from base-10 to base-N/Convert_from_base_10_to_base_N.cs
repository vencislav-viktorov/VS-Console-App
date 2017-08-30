using System;
using System.Numerics;
using System.Text;

namespace _01.Convert_from_base_10_to_base_N
{
    public class Convert_from_base_10_to_base_N
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            long toBase = long.Parse(input[0]);

            BigInteger numberBaseTen = BigInteger.Parse(input[1]);

            StringBuilder result = new StringBuilder();

            while (numberBaseTen > 0)
            {
                BigInteger remainder = numberBaseTen % toBase;

                result.Insert(0, remainder.ToString());

                numberBaseTen /= toBase;
            }

            Console.WriteLine(result);
        }
    }
}

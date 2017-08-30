using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Decode_Radio_Frequencies
{
    public class Decode_Radio_Frequencies
    {
        public static void Main()
        {
            //var text = "83,105 111,110 102,85 116,0";

            var realNumberInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            var result = new List<char>();

            for (int i = 0; i < realNumberInput.Length; i++)
            {
                var integerNumber = GetInteger(realNumberInput[i]);

                var decimalNumber = GetDeciaml(realNumberInput[i]);

                var firsChar = (char)integerNumber;

                var secondChar = (char)decimalNumber;

                if (secondChar > 0)
                {
                    result.Insert(i, secondChar);
                }

                if (firsChar > 0)
                {
                    result.Insert(i, firsChar);
                }
            }

            Console.WriteLine(string.Join("", result));
        }

        static int GetDeciaml(decimal number)
        {
            var integerNumber = (int)number;

            var decimalNumberCheck = (number - integerNumber).ToString();

            var findCharAsciiCode = decimalNumberCheck.ToCharArray();

            var secondHalf = string.Empty;

            for (int i = 2; i < findCharAsciiCode.Length; i++)
            {
                secondHalf += findCharAsciiCode[i];
            }

            var decimalNumber = int.Parse(secondHalf);

            return decimalNumber;
        }

        static int GetInteger(decimal number)
        {
            int integerNumber = (int)number;

            return integerNumber;
        }
    }
}

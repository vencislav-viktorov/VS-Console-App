using System;

namespace _05.Integer_to_Base
{
    public class Integer_to_Base
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int toBase = int.Parse(Console.ReadLine());

            string result = TakeResult(number, toBase);

            Console.WriteLine(result);
        }

        static string TakeResult(int number, int toBase)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int rem = number % toBase;

                result = rem + result;

                number /= toBase;
            }

            return result;
        }
    }
}

using System;

namespace _06.Increment_Variable_second_way
{
    public class Increment_Variable_second_way
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int overflow = num / 256;

            int result = num % 256;

            Console.WriteLine(result);

            if (overflow >= 1)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }
        }
    }
}

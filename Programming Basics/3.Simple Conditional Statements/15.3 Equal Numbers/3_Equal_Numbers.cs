using System;

namespace _15._3_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());

            var num2 = int.Parse(Console.ReadLine());

            var num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

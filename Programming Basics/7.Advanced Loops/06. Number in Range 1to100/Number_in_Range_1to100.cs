using System;

namespace _06.Number_in_Range_1to100
{
    class Number_in_Range_1to100
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");

                num = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("The number is: {0}", num);
        }
    }
}

using System;

namespace _4.Greater_Number
{
    class Greater_Number
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers:");

            var num1 = int.Parse(Console.ReadLine());

            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Greater number: " + num1);
            }

            else
            {
                Console.WriteLine("Greater number: " + num2);
            }

        }
    }
}

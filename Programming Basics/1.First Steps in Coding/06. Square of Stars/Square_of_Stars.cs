using System;

namespace _06.Square_of_Stars
{
    class Square_of_Stars
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            
            for (int i = 0; i < number - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', number - 2));
            }
            
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

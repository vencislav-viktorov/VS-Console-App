using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double a = 1;

            double b = 1;

            double c = 2;

            int[] first3Number = { 1, 1, 2 };

            if (number <= 3)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(first3Number[i] + " ");
                }

                return;
            }

            Console.Write($"{a} {b} {c} ");

            for (int i = 3; i < number; i++)
            {
                double d = a + b + c;

                a = b;

                b = c;

                c = d;

                Console.Write(d + " ");
            }

            Console.WriteLine();
        }
    }
}

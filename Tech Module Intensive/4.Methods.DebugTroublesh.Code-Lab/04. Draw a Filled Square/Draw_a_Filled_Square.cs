using System;

namespace _04.Draw_a_Filled_Square
{
    public class Draw_a_Filled_Square
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooterRow(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderFooterRow(n);
        }

        static void PrintHeaderFooterRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');

        }
    }
}

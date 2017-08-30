using System;

namespace _06.Increment_Variable
{
    public class Increment_Variable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int overflows = 0;

            byte number = 0;

            for (int i = 0; i < n; i++)
            {
                number++;

                if (number == 0)
                {
                    overflows++;
                }
            }

            Console.WriteLine(number);

            if (overflows > 0)
            {
                Console.WriteLine("Overflowed " + overflows + " times");
            }
        }
    }
}
using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());

            char end = char.Parse(Console.ReadLine());

            if (begin > end)
            {
                char temp = begin;
                begin = end;
                end = temp;
            }

            PrintAsciiInRange(begin, end);

        }

        private static void PrintAsciiInRange(char begin, char end)
        {
            begin++;

            for (char symbol = begin; symbol < end; symbol++)
            {
                Console.Write(symbol + " ");
            }

            Console.WriteLine();
        }
    }
}

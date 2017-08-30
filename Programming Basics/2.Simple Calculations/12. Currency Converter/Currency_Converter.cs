using System;

namespace _12.Currency_Converter
{
    class Currency_Converter
    {
        static void Main()
        {
            var value = double.Parse(Console.ReadLine());

            var input = Console.ReadLine().ToUpper();

            var output = Console.ReadLine().ToUpper();

            if (input == "USD")
            {
                value *= 1.79549;
            }

            else if (input == "EUR")
            {
                value *= 1.95583;
            }

            else if (input == "GBP")
            {
                value *= 2.53405;
            }

            else if (input == "BGN")
            {
                value *= 1;
            }

            if (output == "USD")
            {
                value /= 1.79549;
            }

            else if (output == "EUR")
            {
                value /= 1.95583;
            }

            else if (output == "GBP")
            {
                value /= 2.53405;
            }

            else if (output == "BGN")
            {
                value /= 1;
            }

            Console.WriteLine(Math.Round(value, 2) + " " + output);
        }
    }
}

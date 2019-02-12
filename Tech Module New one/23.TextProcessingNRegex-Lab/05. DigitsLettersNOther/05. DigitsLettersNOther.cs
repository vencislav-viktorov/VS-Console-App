using System;

namespace _05._DigitsLettersNOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = string.Empty;

            string letters = string.Empty;

            string others = string.Empty;

            foreach (var symbol in text)
            {
                if (Char.IsDigit(symbol))
                {
                    digits += symbol;
                }

                else if (Char.IsLetter(symbol))
                {
                    letters += symbol;
                }

                else
                {
                    others += symbol;
                }
            }

            Console.WriteLine(digits);

            Console.WriteLine(letters);

            Console.WriteLine(others);
        }
    }
}

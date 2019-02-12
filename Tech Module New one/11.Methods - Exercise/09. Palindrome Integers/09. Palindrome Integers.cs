using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            PalindomeNumbers(number);
        }

        static void PalindomeNumbers(string number)
        {
            while (number != "END")
            {
                string reverseNumbers = string.Empty;

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reverseNumbers += number[i];
                }

                if (number.CompareTo(reverseNumbers) == 0)
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }

                number = Console.ReadLine();
            }
        }
    }
}

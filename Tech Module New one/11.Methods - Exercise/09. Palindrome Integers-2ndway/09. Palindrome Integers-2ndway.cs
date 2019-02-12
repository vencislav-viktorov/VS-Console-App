using System;
using System.Linq;

namespace _09._Palindrome_Integers_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToCheck = Console.ReadLine();

            while (stringToCheck != "END")
            {
                bool isPalindrom = IsPalindomeNumbers(stringToCheck);

                Console.WriteLine(isPalindrom == true ? "true" : "false");

                stringToCheck = Console.ReadLine();
            }
        }

        static bool IsPalindomeNumbers(string stringToCheck)
        {
            char[] reverseString = stringToCheck.Reverse().ToArray();

            return (stringToCheck.Equals(new string(reverseString), StringComparison.OrdinalIgnoreCase));
        }
    }
}

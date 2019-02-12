using System;
using System.Linq;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            CheckedType(type);
        }

        static void CheckedType(string type)
        {
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                GetMaxBetweenTwoNumbersAscii(firstNumber, secondNumber);
            }

            else if (type == "char")
            {
                char firstchar = char.Parse(Console.ReadLine());
                char secondchar = char.Parse(Console.ReadLine());

                GetMaxBetweenTwoCharsAscii(firstchar, secondchar);
            }

            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                GetMaxBetweenTwoStringsAscii(firstString, secondString);
            }
        }

        static void GetMaxBetweenTwoStringsAscii(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                Console.WriteLine(first);
            }

            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMaxBetweenTwoCharsAscii(char first, char second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }

            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMaxBetweenTwoNumbersAscii(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }

            else
            {
                Console.WriteLine(second);
            }
        }
    }
}

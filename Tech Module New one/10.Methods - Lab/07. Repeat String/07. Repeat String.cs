using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, number));
        }

        static string RepeatString(string text, int number)
        {
            string result = string.Empty;

            for (int i  = 0; i < number; i ++)
            {
                result += text;
            }

            return result;
        }
    }
}

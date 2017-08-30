using System;

namespace _03.String_Repeater_second_way
{
    public class String_Repeater_second_way
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            int howManyRepeatTheText = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, howManyRepeatTheText));
        }

        static string RepeatString(string text, int howManyRepeatTheText)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < howManyRepeatTheText; i++)
            {
                repeatedString += text;
            }

            return repeatedString;
        }
    }
}

using System;

namespace _03.String_Repeater
{
    public class String_Repeater
    {
        public static void Main()
        {
            string testString = Console.ReadLine();

            byte repeatCount = byte.Parse(Console.ReadLine());

            Repeat(testString, repeatCount);
        }

        static void Repeat(string testString, byte repeatCount)
        {
            for (int count = 0; count < repeatCount; count++)
            {
                Console.Write(testString);
            }
        }
    }
}

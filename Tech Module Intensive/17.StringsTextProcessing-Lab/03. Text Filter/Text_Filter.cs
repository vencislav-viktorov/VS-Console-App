using System;

namespace _03.Text_Filter
{
    public class Text_Filter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}

using System;
using System.Collections.Generic;

namespace _09.Index_of_Letters
{
    public class Index_of_Letters
    {
        public static void Main()
        {
            char[] word = Console.ReadLine().ToLower().ToCharArray();

            PositionFinder(word);
        }

        static void PositionFinder(char[] word)
        {
            Dictionary<char, int> lettersAndPos = new Dictionary<char, int>();

            int pos = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (!lettersAndPos.ContainsKey(i))
                {
                    lettersAndPos.Add(i, pos);
                }

                pos++;
            }

            foreach (char c in word)
            {
                if (lettersAndPos.ContainsKey(c))
                {
                    Console.WriteLine($"{c} -> {lettersAndPos[c]}");
                }
            }
        }
    }
}

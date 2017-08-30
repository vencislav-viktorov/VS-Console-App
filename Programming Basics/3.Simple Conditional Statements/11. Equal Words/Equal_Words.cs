using System;

namespace _11.Equal_Words
{
    class Equal_Words
    {
        static void Main()
        {
            string word = Console.ReadLine().ToLower();

            string word2 = Console.ReadLine().ToLower();

            if (word == word2)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

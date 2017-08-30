using System;

namespace _15.Count_of_Capital_Letters
{
    public class Count_of_Capital_Letters
    {
        public static void Main()
        {
            string[] massive = Console.ReadLine()
                .Split(' ');

            int count = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                string currentWord = massive[i];

                if (currentWord.Length == 1)
                {
                    char currentChar = currentWord[0];

                    if (currentChar >= 65 && currentChar <= 90)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}

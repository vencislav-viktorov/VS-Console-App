using System;

namespace _02.Randomize_Words_second_way
{
    public class Randomize_Words_second_way
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);

                string temp = words[i];

                words[i] = words[index];

                words[index] = temp;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}

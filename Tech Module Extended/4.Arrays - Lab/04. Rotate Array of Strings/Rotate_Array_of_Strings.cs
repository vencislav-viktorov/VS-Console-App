using System;

namespace _04.Rotate_Array_of_Strings
{
    public class Rotate_Array_of_Strings
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            string[] newWords = new string[words.Length];

            newWords[0] = words[words.Length - 1];

            for (int i = 0; i < words.Length - 1; i++)
            {
                newWords[i + 1] = words[i];
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(newWords[i] + " ");
            }
        }
    }
}

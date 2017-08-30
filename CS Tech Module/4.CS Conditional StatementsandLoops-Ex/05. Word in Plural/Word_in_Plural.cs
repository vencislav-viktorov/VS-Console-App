using System;

namespace _05.Word_in_Plural
{
    public class Word_in_Plural
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            char one = word[word.Length - 1];

            char two = word[word.Length - 2];

            if (one == 'y')
            {
                word = word.Remove(word.Length - 1);

                Console.WriteLine(word + "ies");
            }

            else if (one == 'o' || one == 's' || one == 'x' || one == 'z' || (one == 'h' && two == 'c' || two == 's'))
            {
                Console.WriteLine(word + "es");
            }

            else
            {
                Console.WriteLine(word + "s");
            }
        }
    }
}
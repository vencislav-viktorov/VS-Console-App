using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes_second_way
{
    public class Palindromes_second_way
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var word in text)
            {
                bool isPalindrome = CheckWord(word);

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static bool CheckWord(string word)
        {
            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if (reversed == word)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
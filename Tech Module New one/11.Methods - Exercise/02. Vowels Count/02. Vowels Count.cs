using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            Console.WriteLine(GetCountOfTheVowels(text));
        }

        private static int GetCountOfTheVowels(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        counter++;
                        break;

                    case 'e':
                        counter++;
                        break;

                    case 'o':
                        counter++;
                        break;

                    case 'u':
                        counter++;
                        break;

                    case 'i':
                        counter++;
                        break;

                    default:
                        break;
                }
            }

            return counter;
        }
    }
}

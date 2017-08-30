using System;

namespace _02.Count_Substring_Occurrences
{
    public class Count_Substring_Occurrences
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();

            string pattern = Console.ReadLine().ToLower();

            int counter = 0;

            int index = inputText.IndexOf(pattern);

            while (index != -1)
            {
                counter++;

                index = inputText.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}

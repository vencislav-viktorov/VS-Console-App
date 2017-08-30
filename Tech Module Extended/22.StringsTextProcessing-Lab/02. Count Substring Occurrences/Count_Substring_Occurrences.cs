using System;

namespace _02.Count_Substring_Occurrences
{
    public class Count_Substring_Occurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();

            var pattern = Console.ReadLine().ToLower();

            var count = 0;

            var index = text.IndexOf(pattern);

            while (index != -1)
            {
                count++;

                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}

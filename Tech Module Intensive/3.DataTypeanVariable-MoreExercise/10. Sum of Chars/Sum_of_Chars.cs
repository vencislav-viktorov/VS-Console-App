using System;

namespace _10.Sum_of_Chars
{
    public class Sum_of_Chars
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sum += (int) character;
            }

            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}
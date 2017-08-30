using System;

namespace _09.Make_a_Word
{
    public class Make_a_Word
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string sum = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sum += character;
            }

            Console.WriteLine("The word is: {0}", sum);
        }
    }
}

using System;

namespace _13.Decrypting_Message
{
    public class Decrypting_Message
    {
        public static void Main()
        {
            int letter = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            string sum = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sum += (char)((int)character + letter);
            }

            Console.WriteLine("{0}", sum);
        }
    }
}

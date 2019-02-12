using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] += (char)3;
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}

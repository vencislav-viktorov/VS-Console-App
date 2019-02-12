using System;

namespace _4._Reverse_String
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();

            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}

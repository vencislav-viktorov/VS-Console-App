using System;

namespace _04._ReverseArrayofStrings_3rdway
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array= Console.ReadLine().Split(' ');

            Array.Reverse(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}

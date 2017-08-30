using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    public class Compare_Char_Arrays
    {
        public static void Main()
        {
            char[] arrayOne = Console.ReadLine().Split(' ')
                .Select(char.Parse)
                .ToArray();

            char[] arrayTwo = Console.ReadLine().Split(' ')
                .Select(char.Parse)
                .ToArray();

            bool oneIsFirst = false;

            bool twoIsFirst = false;

            var smallerArrayLength = Math.Min(arrayOne.Length, arrayTwo.Length);

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    oneIsFirst = true;

                    break;
                }

                else if (arrayOne[i] > arrayTwo[i])
                {
                    twoIsFirst = true;

                    break;
                }
            }

            if (oneIsFirst)
            {
                Console.WriteLine(string.Join("", arrayOne));
                Console.WriteLine(string.Join("", arrayTwo));
            }

            else if (twoIsFirst)
            {
                Console.WriteLine(string.Join("", arrayTwo));
                Console.WriteLine(string.Join("", arrayOne));
            }

            else
            {
                if (arrayOne.Length > arrayTwo.Length)
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                }

                else
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                }
            }
        }
    }
}

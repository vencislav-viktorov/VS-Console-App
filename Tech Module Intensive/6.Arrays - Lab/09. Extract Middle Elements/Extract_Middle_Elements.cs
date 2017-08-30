using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    public class Extract_Middle_Elements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            TypeSelector(array);

        }

        static void TypeSelector(int[] array)
        {
            int arrayToLength = array.Length;

            if (arrayToLength == 1)
            {
                One(array);
            }

            else if (arrayToLength % 2 == 0)
            {
                Even(array);
            }

            else
            {
                Odd(array);
            }
        }

        static void One(int[] array)
        {
            Console.WriteLine(array[0]);
        }

        static void Even(int[] array)
        {
            Console.WriteLine($"{array[array.Length / 2 - 1]}, {array[array.Length / 2]}");
        }

        static void Odd(int[] array)
        {
            Console.WriteLine($"{array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]}");
        }
    }
}
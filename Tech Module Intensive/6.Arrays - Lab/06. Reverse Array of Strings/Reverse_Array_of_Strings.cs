using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    public class Reverse_Array_of_Strings
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                SwapElements(numbers, i, numbers.Length - 1 - i);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void SwapElements(string[] arr, int i, int j)
        {
            var oldElement = arr[i];

            arr[i] = arr[j];

            arr[j] = oldElement;
        }
    }
}

using System;

namespace _02.Reverse_Array_of_Integers
{
    public class Reverse_Array_of_Integers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

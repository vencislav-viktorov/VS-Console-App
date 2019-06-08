using System;
using System.Linq;

namespace _01._Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            PrintInReverseOrder(arr, arr.Length - 1);
        }

        private static void PrintInReverseOrder(int[] arr, int index)
        {
            if (index < 0)
            {
                return;
            }

            Console.Write(arr[index] + " ");
            PrintInReverseOrder(arr, index - 1);
        }
    }
}
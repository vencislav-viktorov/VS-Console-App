using System;

namespace _02._PrintNuminReverseOrder_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersArray[i] = number;
            }

            for (int j = numbersArray.Length - 1; j >= 0; j--)
            {
                Console.Write(numbersArray[j] + " ");
            }
        }
    }
}

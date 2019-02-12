using System;

namespace _02._Print_Numbers_in_Reverse_Order
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

            Array.Reverse(numbersArray);
            Console.WriteLine(String.Join(" ", numbersArray));
        }
    }
}

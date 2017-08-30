using System;

namespace _01.Sum_Array_Elements
{
    public class Sum_Array_Elements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                newArray[i] = m;
                sum += newArray[i];
            }

            Console.WriteLine(sum);
        }
    }
}

using System;

namespace _09.Largest_Element_second_way
{
    public class Largest_Element_second_way
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] massive = new int[n];

            int biggest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                massive[i] = int.Parse(Console.ReadLine());

                if (massive[i] > biggest)
                {
                    biggest = massive[i];
                }
            }

            Console.WriteLine(biggest);
        }
    }
}

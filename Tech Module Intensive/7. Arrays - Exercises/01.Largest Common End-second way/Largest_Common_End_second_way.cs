using System;

namespace _01.Largest_Common_End_second_way
{
    public class Largest_Common_End_second_way
    {
        public static void Main()
        {
            string[] arrayOne = Console.ReadLine().Split();

            string[] arrayTwo = Console.ReadLine().Split();

            int leftCount = 0;

            int rightCount = 0;

            var smallerArrayLength = Math.Min(arrayOne.Length, arrayTwo.Length);

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    leftCount++;
                }

                if (arrayOne[arrayOne.Length - 1 - i] == arrayTwo[arrayTwo.Length - 1 - i])
                {
                    rightCount++;
                }
            }
            
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}

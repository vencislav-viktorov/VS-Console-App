using System;
using System.Linq;

namespace _08.Most_Frequent_Number_fourth_way
{
    public class Most_Frequent_Number_fourth_way
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int resultNumber = 0;

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCounter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        tempCounter++;
                    }
                }

                if (tempCounter > counter)
                {
                    counter = tempCounter;

                    resultNumber = numbers[i];
                }
            }

            Console.WriteLine(resultNumber);
        }
    }
}

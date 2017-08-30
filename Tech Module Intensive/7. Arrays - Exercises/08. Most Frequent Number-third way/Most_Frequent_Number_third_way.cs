using System;
using System.Linq;

namespace _08.Most_Frequent_Number_third_way
{
    public class Most_Frequent_Number_third_way
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int resultNumber = 0;

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCounter = 0;

                foreach (var number in numbers)
                {
                    if (numbers[i] == number)
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

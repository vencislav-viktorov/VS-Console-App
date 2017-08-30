using System;

namespace _02.ArrayElementsEqualtoTheirIndex
{
    public class ArrayElementsEqualtoTheirIndex
    {
        public static void Main()
        {
            var givenNumbers = Console.ReadLine().Split();

            var currentNumber = 0;

            var counter = givenNumbers.Length;

            for (int index = 0; index < counter; index++)
            {
                currentNumber = Convert.ToInt32(givenNumbers[index]);

                if (index == currentNumber)
                {
                    Console.Write("{0} ", currentNumber);
                }
            }
        }
    }
}

using System;

namespace _08.Sum_of_Odd_Numbers
{
    public class Sum_of_Odd_Numbers
    {
        public static void Main()
        {
            var loopLength = int.Parse(Console.ReadLine());

            var sum = 0;

            var loopLengthCounter = 0;

            var oddNumbers = 1;

            while (loopLengthCounter != loopLength)
            {
                Console.WriteLine(oddNumbers);

                sum += oddNumbers;

                oddNumbers += 2;

                loopLengthCounter++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

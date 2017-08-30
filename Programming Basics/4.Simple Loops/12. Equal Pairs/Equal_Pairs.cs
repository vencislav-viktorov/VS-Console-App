using System;

namespace _12.Equal_Pairs
{
    class Equal_Pairs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double previousPairSum = 0;

            double currentPairSum = 0;

            double difference = 0;

            double biggestdifference = 0;

            for (int i = 0; i < n; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());

                double secondNumber = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousPairSum = firstNumber + secondNumber;
                }

                else
                {
                    currentPairSum = firstNumber + secondNumber;

                    difference = Math.Abs(currentPairSum - previousPairSum);

                    if (difference > biggestdifference)
                    {
                        biggestdifference = difference;
                    }

                    previousPairSum = currentPairSum;
                }
            }


            if (biggestdifference == 0)
            {
                Console.WriteLine("Yes, value ={0}", previousPairSum);
            }

            else
            {
                Console.WriteLine("No, maxdiff ={0}", biggestdifference);
            }
        }
    }
}

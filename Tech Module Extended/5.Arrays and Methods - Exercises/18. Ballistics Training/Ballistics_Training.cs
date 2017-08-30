using System;
using System.Linq;

namespace _18.Ballistics_Training
{
    public class Ballistics_Training
    {
        public static void Main()
        {
            int[] firstMassive = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] secondMassive = Console.ReadLine().Split(' ').ToArray();

            int xAxis = 0;

            int yAxis = 0;

            for (int i = 0; i < secondMassive.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (secondMassive[i] == "left")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);

                        xAxis -= addition;
                    }

                    else if (secondMassive[i] == "right")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);

                        xAxis += addition;
                    }

                    else if (secondMassive[i] == "up")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);

                        yAxis += addition;
                    }

                    else if (secondMassive[i] == "down")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);

                        yAxis -= addition;
                    }
                }
            }

            if (xAxis == firstMassive[0] && yAxis == firstMassive[1])
            {
                Console.WriteLine("firing at [{0}, {1}]", xAxis, yAxis);

                Console.WriteLine("got 'em!");
            }

            else
            {
                Console.WriteLine("firing at [{0}, {1}]", xAxis, yAxis);

                Console.WriteLine("better luck next time...");
            }
        }
    }
}

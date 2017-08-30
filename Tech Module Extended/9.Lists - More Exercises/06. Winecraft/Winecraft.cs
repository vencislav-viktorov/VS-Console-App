using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Winecraft
{
    public class Winecraft
    {
        public static void Main()
        {
            //var text = "5 5 15 5 5";

            var grapes = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDays)
            {
                for (int currentRound = 0; currentRound < growthDays; currentRound++)
                {
                    IncrementAllGrapes(grapes);

                    ProcessGrapes(grapes);
                }

                RemoveGrapsSmallerThanN(grapes, growthDays);
            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        static void ProcessGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                var isFirstElement = i == 0;

                var isLastElement = i == grapes.Count - 1;

                if (!isFirstElement && !isLastElement)
                {
                    var previusIndex = i - 1;

                    var nextIndex = i + 1;

                    var isGreaterThanPrevius = grapes[i] > grapes[previusIndex];

                    var isGreaterThanNext = grapes[i] > grapes[nextIndex];

                    var isGreaterGrape = isGreaterThanPrevius && isGreaterThanNext;

                    if (isGreaterGrape)
                    {
                        grapes[i]--;

                        if (grapes[previusIndex] > 0)
                        {
                            grapes[i]++;

                            grapes[previusIndex] = Math.Max(grapes[previusIndex] - 2, 0);
                        }

                        if (grapes[nextIndex] > 0)
                        {
                            grapes[i]++;

                            grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                        }
                    }
                }
            }
        }

        static void IncrementAllGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {

                grapes[i]++;
            }
        }

        static void RemoveGrapsSmallerThanN(List<int> grapes, int n)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= n)
                {
                    grapes.RemoveAt(i);

                    i--;
                }
            }
        }
    }
}

using System;
using System.Linq;

namespace _04.Grab_and_Go
{
    public class Grab_and_Go
    {
        public static void Main()
        {
            var numArray = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var findLastNum = long.Parse(Console.ReadLine());

            if (numArray.Contains(findLastNum))
            {
                int index = 0;

                for (int i = 0; i < numArray.Length; i++)
                {
                    if (numArray[i] == findLastNum)
                    {
                        index = i;
                    }
                }

                Console.WriteLine(
                    numArray
                    .Take(index)
                    .Sum()
                    );
            }

            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}

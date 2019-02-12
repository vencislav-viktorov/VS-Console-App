using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    public class Program
    {
        public static void Main()
        {
            int DNALength = int.Parse(Console.ReadLine());

            int lenghth = 0;
            int sum = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;

            int[] DNA = new int[DNALength];

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = line
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }

                if (currentRow == 1)
                {
                    DNA = currentDNA;
                    row = currentRow;
                    sum = currentSum;
                }

                int currentStartIndex = -1;
                int currentLength = 0;
                bool isFound = false;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }

                        currentLength++;

                        if (currentLength > lenghth)
                        {
                            lenghth = currentLength;
                            startIndex = currentStartIndex;
                            sum = currentSum;
                            row = currentRow;

                            DNA = currentDNA;
                        }

                        else if (currentLength == lenghth)
                        {
                            if (currentStartIndex < startIndex)
                            {
                                lenghth = currentLength;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;

                                DNA = currentDNA;
                            }

                            else if (currentSum > sum)
                            {
                                lenghth = currentLength;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;

                                DNA = currentDNA;
                            }
                        }
                    }

                    else
                    {
                        currentStartIndex = -1;
                        currentLength = 0;
                        isFound = false;
                    }
                }

                currentRow++;
            }

            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._LongestIncreasingSubsequence
{
    class Program
    {
        const int NO_PREVIOUS = -1;

        static void Main()
        {
            int[] seq = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[seq.Length];

            int[] prev = new int[seq.Length];

            int bestIndex = CalculateLongestIncreasingSubsequence
                (seq, len, prev);

            //Console.WriteLine("seq[] = " + string.Join(", ", seq));

            //Console.WriteLine("len[] = " + string.Join(", ", len));

            //Console.WriteLine("prev[] = " + string.Join(", ", prev));

            PrintLongestIncreasingSubsequence(seq, prev, bestIndex);
        }

        private static int CalculateLongestIncreasingSubsequence(
            int[] seq, int[] len, int[] prev)
        {
            int bestLen = 0;
            int bestIndex = 0;

            for (int x = 0; x < seq.Length; x++)
            {
                len[x] = 1;
                prev[x] = NO_PREVIOUS;

                for (int i = 0; i <= x - 1; i++)
                {
                    if (seq[i] < seq[x] && len[i] + 1 > len[x])
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                        
                        if (len[x] > bestLen)
                        {
                            bestLen = len[x];
                            bestIndex = x;
                        }
                    }
                }
            }

            return bestIndex;
        }

        static void PrintLongestIncreasingSubsequence(
            int[] seq, int[] prev, int index)
        {
            List<int> lis = new List<int>();

            while (index != NO_PREVIOUS)
            {
                lis.Add(seq[index]);
                index = prev[index];
            }

            lis.Reverse();
            Console.WriteLine(String.Join(" ", lis));
        }
    }
}
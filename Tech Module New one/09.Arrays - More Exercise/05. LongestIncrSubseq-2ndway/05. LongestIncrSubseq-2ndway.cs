using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._LongestIncrSubseq_2ndway
{
    class Program
    {
        static void Main()
        {
            int[] seq = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[seq.Length];

            int[] prev = new int[seq.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < seq.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j <= i - 1; j++)
                {
                    if (seq[j] < seq[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }


                    if (len[i] > maxLen)
                    {
                        maxLen = len[i];
                        lastIndex = i;
                    }
                }
            }
            
            var longestSeq = new List<int>();

            while (lastIndex != -1)
            {
                longestSeq.Add(seq[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            
            longestSeq.Reverse();

            if (seq.Length == 1)
            {
                Console.WriteLine(string.Join("", seq));
                return;
            }

            Console.WriteLine(String.Join(" ", longestSeq));
        }
    }
}

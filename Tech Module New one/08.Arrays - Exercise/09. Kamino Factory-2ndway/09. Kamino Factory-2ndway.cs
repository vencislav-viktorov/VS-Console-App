using System;

namespace _09._Kamino_Factory_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            int bestLength = 0;
            string bestDna = String.Empty;
            int bestIndex = 0;
            int bestSum = 0;
            int bestCounter = 0;
            int counter = 0;

            while (line != "Clone them!")
            {
                counter++;

                string sequence = line.Replace("!", "");

                string[] dnas = sequence.Split('0');

                int maxLength = 0;
                int sum = 0;
                string bestLocalDna = String.Empty;

                for (int i = 0; i < dnas.Length; i++)
                {
                    if (dnas[i].Length > maxLength)
                    {
                        maxLength = dnas[i].Length;
                        bestLocalDna = dnas[i];
                    }

                    sum += dnas[i].Length;
                }

                int beginIndex = sequence.IndexOf(bestLocalDna);


                if (maxLength > bestLength)
                {
                    bestLength = maxLength;
                    bestDna = sequence;
                    bestIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }

                else if (maxLength == bestLength && (beginIndex < bestIndex || sum > bestSum))
                {
                    bestLength = maxLength;
                    bestDna = sequence;
                    bestIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }

                else if (counter == 1)
                {
                    bestLength = maxLength;
                    bestDna = sequence;
                    bestIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");

            for (int j = 0; j < bestDna.Length; j++)
            {
                Console.Write(bestDna[j] + " ");
            }

            Console.WriteLine();
        }
    }
}

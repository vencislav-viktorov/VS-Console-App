using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var reversedLeftSocks = new List<int>();

            for (int i = leftSocks.Count - 1; i >= 0; i--)
            {
                var num = leftSocks[i];
                reversedLeftSocks.Add(num);
            }

            var rightSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var pairOfSocks = new List<int>();

            while (reversedLeftSocks.Any() && rightSocks.Any())
            {
                var currentLeft = reversedLeftSocks[0];
                var currentRight = rightSocks[0];

                if (currentLeft > currentRight)
                {
                    var currentPair = currentLeft + currentRight;
                    pairOfSocks.Add(currentPair);
                    reversedLeftSocks.RemoveAt(0);
                    rightSocks.RemoveAt(0);
                }

                else if (currentRight > currentLeft)
                {
                    reversedLeftSocks.RemoveAt(0);
                }

                else if (currentLeft == currentRight)
                {
                    rightSocks.RemoveAt(0);
                    reversedLeftSocks[0]++;
                }
            }

            Console.WriteLine(pairOfSocks.Max());
            Console.WriteLine(string.Join(" ", pairOfSocks));
        }
    }
}
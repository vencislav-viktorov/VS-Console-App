using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Socks___second_way_with_stackNQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftSocksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rightSocksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var leftSocks = new Stack<int>(leftSocksInput);

            var rightSocks = new Queue<int>(rightSocksInput);

            var pairsOfSocks = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                var currentLeftSocks = leftSocks.Peek();
                var currentRightSocks = rightSocks.Peek();

                if (currentLeftSocks > currentRightSocks)
                {
                    var currentPairOfSocks = currentLeftSocks + currentRightSocks;
                    pairsOfSocks.Add(currentPairOfSocks);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }

                else if (currentRightSocks > currentLeftSocks)
                {
                    leftSocks.Pop();
                }

                else
                {
                    rightSocks.Dequeue();
                    var leftSockIncrement = leftSocks.Pop() + 1;
                    leftSocks.Push(leftSockIncrement);
                }
            }

            Console.WriteLine(pairsOfSocks.Max());
            Console.WriteLine(string.Join(" ", pairsOfSocks));

        }
    }
}

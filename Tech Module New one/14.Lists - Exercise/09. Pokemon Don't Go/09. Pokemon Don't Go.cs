using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            var number = 0;

            while (sequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    var lastElement = sequence[sequence.Count - 1];

                    number = sequence[0];

                    sum += number;

                    sequence.RemoveAt(0);

                    sequence.Insert(0, lastElement);
                }

                else if (index > sequence.Count - 1)
                {
                    var firstElement = sequence[0];

                    number = sequence[sequence.Count - 1];

                    sum += number;
                    
                    sequence.RemoveAt(sequence.Count - 1);

                    sequence.Insert(sequence.Count, firstElement);
                }

                else
                {
                    number = sequence[index];
                    
                    sum += number;

                    sequence.RemoveAt(index);
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= number)
                    {
                        sequence[i] += number;
                    }

                    else
                    {
                        sequence[i] -= number;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}

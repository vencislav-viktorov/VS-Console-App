using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_Negatives_and_Reverse
{
    public class Remove_Negatives_and_Reverse
    {
        public static void Main()
        {
            var integer = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var answer = new List<int>();

            for (var i = 0; i < integer.Count; i++)
            {
                if (integer[i] >= 0)
                {
                    answer.Add(integer[i]);
                }
            }

            answer.Reverse();

            if (answer.Count > 0)
            {
                Console.WriteLine(string.Join(" ", answer));
            }

            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}

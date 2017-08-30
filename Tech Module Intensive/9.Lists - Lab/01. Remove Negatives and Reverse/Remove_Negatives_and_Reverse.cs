using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_Negatives_and_Reverse
{
    public class Remove_Negatives_and_Reverse
    {
        public static void Main()
        {
            List<int> listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int cycle = 0; cycle < listOfDigits.Count; cycle++)
            {
                if (listOfDigits[cycle] < 0)
                {
                    listOfDigits.RemoveAt(cycle);

                    cycle--;
                }
            }

            listOfDigits.Reverse();

            if (listOfDigits.Count > 0)
            {
                Console.WriteLine(string.Join(" ", listOfDigits));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

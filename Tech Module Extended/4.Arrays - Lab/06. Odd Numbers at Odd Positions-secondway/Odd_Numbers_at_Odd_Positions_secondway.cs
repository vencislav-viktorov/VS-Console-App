using System;
using System.Linq;

namespace _06.Odd_Numbers_at_Odd_Positions_secondway
{
    public class Odd_Numbers_at_Odd_Positions_secondway
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int cnt = 1; cnt < arr.Length; cnt += 2)
            {
                if (arr[cnt] % 2 != 0)
                {
                    Console.WriteLine($"Index {cnt} -> {arr[cnt]}");
                }
            }
        }
    }
}

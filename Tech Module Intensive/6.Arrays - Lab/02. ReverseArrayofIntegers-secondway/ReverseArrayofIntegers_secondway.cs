using System;
using System.Linq;

namespace _02.ReverseArrayofIntegers_secondway
{
    public class ReverseArrayofIntegers_secondway
    {
        public static void Main()
        {
            Console.WriteLine(String.Join(" ", 
                Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray().Reverse()));
        }
    }
}

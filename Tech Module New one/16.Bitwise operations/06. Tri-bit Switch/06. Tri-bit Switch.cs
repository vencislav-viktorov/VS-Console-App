using System;
using System.Linq;

namespace _06._Tri_bit_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            string inputPosition = Console.ReadLine();

            int number = int.Parse(inputNumber);

            int position = int.Parse(inputPosition);

            int mask = 7 << position;

            int result = number ^ mask;

            Console.WriteLine(result);
        }
    }
}

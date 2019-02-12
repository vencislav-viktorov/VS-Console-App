using System;

namespace _04._Bit_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            string inputP = Console.ReadLine();

            int numberN = int.Parse(inputN);

            int numberP = int.Parse(inputP);

            int mask = ~(1 << numberP);

            int result = numberN & mask;

            Console.WriteLine(result);
        }
    }
}

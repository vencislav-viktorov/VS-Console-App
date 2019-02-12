using System;

namespace _02._First_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            int numberN = int.Parse(inputN);

            int shiftedNumber = numberN >> 1;

            int result = shiftedNumber & 1;

            Console.WriteLine(result);
        }
    }
}

using System;

namespace _03._p_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            string inputP = Console.ReadLine();

            int numberN = int.Parse(inputN);

            int numberP = int.Parse(inputP);

            int shiftedNumber = numberN >> numberP;

            int result = shiftedNumber & 1;

            Console.WriteLine(result);
        }
    }
}

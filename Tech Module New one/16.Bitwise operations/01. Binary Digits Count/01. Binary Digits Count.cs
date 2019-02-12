using System;

namespace _01._Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputN = Console.ReadLine();

            string inputB = Console.ReadLine();

            int numberN = int.Parse(inputN);

            string binaryN = Convert.ToString(numberN, 2);

            int result = 0;

            for (int i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[i].ToString() == inputB)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

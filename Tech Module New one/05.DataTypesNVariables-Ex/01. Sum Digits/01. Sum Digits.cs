using System;

namespace _01._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();
            int sum = 0;

            foreach (int symbol in input)
            {
                sum += symbol - '0';
            }

            Console.WriteLine(sum);
        }
    }
}

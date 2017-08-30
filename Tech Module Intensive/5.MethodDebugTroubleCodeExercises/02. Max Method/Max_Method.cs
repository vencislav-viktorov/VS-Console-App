using System;

namespace _02.Max_Method
{
    public class Max_Method
    {
        public static void Main()
        {
            int ab = GetMax(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));

            int biggestNumber = GetMax(ab, int.Parse(Console.ReadLine()));

            Console.WriteLine(biggestNumber);
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }
    }
}
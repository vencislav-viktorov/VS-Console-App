using System;

namespace _02.Multiply_an_Array_of_Doubles
{
    public class Multiply_an_Array_of_Doubles
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            string[] result = input.Split();

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(double.Parse(result[i]) * p + " ");
            }
        }
    }
}

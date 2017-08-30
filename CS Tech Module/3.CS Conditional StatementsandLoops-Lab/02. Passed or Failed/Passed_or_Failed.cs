using System;

namespace _02.Passed_or_Failed
{
    public class Passed_or_Failed
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }

            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}

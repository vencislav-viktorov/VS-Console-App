using System;

namespace _2.Excellent_or_Not
{
    class Excellent_or_Not
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }

            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}

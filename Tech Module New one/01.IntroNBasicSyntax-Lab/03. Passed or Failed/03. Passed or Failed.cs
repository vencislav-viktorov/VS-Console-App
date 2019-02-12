using System;

namespace _03._Passed_or_Failed
{
    public class Program
    {
        public static void Main()
        {
            var grade = decimal.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine($"Passed!");
            }
            else
            {
                Console.WriteLine($"Failed!");
            }
        }
    }
}

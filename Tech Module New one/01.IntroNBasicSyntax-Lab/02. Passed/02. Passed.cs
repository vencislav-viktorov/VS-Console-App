using System;

namespace _02._Passed
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
        }
    }
}

using System;

namespace _12.Number_Checker
{
    public class Number_Checker
    {
        public static void Main()
        {
            try
            {
                double.Parse(Console.ReadLine());

                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

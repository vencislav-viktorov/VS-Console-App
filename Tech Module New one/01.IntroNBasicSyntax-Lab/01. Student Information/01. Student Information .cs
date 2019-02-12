using System;

namespace _01._Student_Information
{
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            var age = double.Parse(Console.ReadLine());
            var grade = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}

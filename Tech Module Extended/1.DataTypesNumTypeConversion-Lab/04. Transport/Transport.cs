using System;

namespace _04.Transport
{
    public class Transport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)n / (4 + 8 + 12));

            Console.WriteLine(courses);
        }
    }
}
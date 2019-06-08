using System;

namespace GenericBoxofInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var content = int.Parse(Console.ReadLine());
                var boxWithString = new Box<int>(content);
                Console.WriteLine(boxWithString.ToString());
            }
        }
    }
}

using System;

namespace GenericBoxofString
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var content = Console.ReadLine();
                var boxWithString = new Box<string>(content);
                Console.WriteLine(boxWithString.ToString());
            }
        }
    }
}

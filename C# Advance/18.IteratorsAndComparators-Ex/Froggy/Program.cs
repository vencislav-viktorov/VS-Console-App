namespace Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var stoneValues = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            var lake = new Lake(stoneValues);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
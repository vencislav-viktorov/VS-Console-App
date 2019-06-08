using System;

namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split();
            var name = firstInput[0] + " " + firstInput[1];
            var address = firstInput[2];
            var firstTuple = new Tuple<string, string>(name, address);

            var secondInput = Console.ReadLine()
                .Split();
            var secondName = secondInput[0];
            var liters = int.Parse(secondInput[1]);
            var secondTuple = new Tuple<string, int>(secondName, liters);

            var thirdInput = Console.ReadLine()
                .Split();
            var intNumber = int.Parse(thirdInput[0]);
            var doubleNumber = double.Parse(thirdInput[1]);
            var thirdTuple = new Tuple<int, double>(intNumber, doubleNumber);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}

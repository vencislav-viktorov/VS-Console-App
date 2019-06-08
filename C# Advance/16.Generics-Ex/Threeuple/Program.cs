using System;

namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split();
            var name = firstInput[0] + " " + firstInput[1];
            var address = firstInput[2];
            var town = firstInput[3];
            var firstTuple = new Threeuple<string, string, string>(name, address, town);

            var secondInput = Console.ReadLine()
                .Split();
            var secondName = secondInput[0];
            var liters = int.Parse(secondInput[1]);
            var isDrunk = secondInput[2].ToLower() == "drunk" ? true : false; 
            var secondTuple = new Threeuple<string, int, bool>(secondName, liters, isDrunk);

            var thirdInput = Console.ReadLine()
                .Split();
            var thirdName = thirdInput[0];
            var balance = double.Parse(thirdInput[1]);
            var bankName = thirdInput[2];
            var thirdTuple = new Threeuple<string, double, string>(thirdName, balance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}

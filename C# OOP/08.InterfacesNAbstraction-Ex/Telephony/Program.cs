namespace Telephony
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split();

            var urls = Console.ReadLine()
                .Split();

            var smartphone = new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
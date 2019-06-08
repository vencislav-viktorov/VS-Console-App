namespace Ferrari
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var driverName = Console.ReadLine();

            var ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari);
        }
    }
}
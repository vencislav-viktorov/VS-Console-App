namespace Logger
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var countOfAppenders = int.Parse(Console.ReadLine());
            var controller = new Controller();
            controller.Act(countOfAppenders);
        }
    }
}
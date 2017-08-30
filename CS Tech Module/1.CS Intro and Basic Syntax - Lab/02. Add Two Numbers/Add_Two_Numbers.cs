using System;

namespace _02.Add_Two_Numbers
{
    public class Add_Two_Numbers
    {
        public static void Main()
        {
            var firstnumber = int.Parse(Console.ReadLine());

            var secondnumber = int.Parse(Console.ReadLine());

            var sum = firstnumber + secondnumber;

            Console.WriteLine("{0} + {1} = {2}", firstnumber, secondnumber, sum);
        }
    }
}
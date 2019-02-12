using System;

namespace _11._Multiplication_Table_2._0
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }

            while (times <= 10);
        }
    }
}

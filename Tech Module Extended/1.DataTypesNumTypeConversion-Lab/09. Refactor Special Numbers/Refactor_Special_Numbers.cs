using System;

namespace _09.Refactor_Special_Numbers
{
    public class Refactor_Special_Numbers
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var currentnumber = i;

                var sum = 0;

                foreach (var symbol in currentnumber.ToString())
                {
                    var digit = symbol - '0';

                    sum += digit;
                }

                var result = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}
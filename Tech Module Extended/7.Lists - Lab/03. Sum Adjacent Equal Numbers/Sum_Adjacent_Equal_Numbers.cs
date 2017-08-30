using System;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class Sum_Adjacent_Equal_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            numbers.Add(int.MaxValue);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    var sum = numbers[i] + numbers[i + 1];

                    numbers[i + 1] = sum;

                    numbers.RemoveAt(i);

                    i = -1;
                }
            }

            numbers.RemoveAt(numbers.Count - 1);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

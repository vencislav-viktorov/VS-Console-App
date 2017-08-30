using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Integer_Insertion
{
    public class Integer_Insertion
    {
        public static void Main()
        {
            //var text = "1 2 3 4 5 6 7 8 9";
            var inputListOfNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var stringNumbers = Console.ReadLine();

            stringNumbers = AddNumberAtIndexPosition(stringNumbers, inputListOfNumbers);

            Console.WriteLine(stringNumbers);
        }

        static string AddNumberAtIndexPosition(string stringNumbers, List<int> inputListOfNumbers)
        {
            while (stringNumbers != "end")
            {
                var number = 0;

                int.TryParse(stringNumbers, out number);

                var index = number;

                while (index > 10)
                {
                    index /= 10;
                }

                if (index < 10 && index >= 0)
                {
                    inputListOfNumbers.Insert(index, number);
                }

                stringNumbers = Console.ReadLine();
            }

            var result = string.Join(" ", inputListOfNumbers);

            return result;
        }
    }
}

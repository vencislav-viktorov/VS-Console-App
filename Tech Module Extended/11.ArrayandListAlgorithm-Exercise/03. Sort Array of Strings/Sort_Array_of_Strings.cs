using System;
using System.Linq;

namespace _03.Sort_Array_of_Strings
{
    public class Sort_Array_of_Strings
    {
        public static void Main()
        {
            //var text = "abc abc test 123 123 test";

            var arrayOfStrings = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                for (int sort = 0; sort < arrayOfStrings.Length - 1; sort++)
                {
                    var first = arrayOfStrings[sort];

                    var second = arrayOfStrings[sort + 1];

                    if (first.CompareTo(second) > 0)
                    {
                        arrayOfStrings[sort] = second;

                        arrayOfStrings[sort + 1] = first;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }
    }
}

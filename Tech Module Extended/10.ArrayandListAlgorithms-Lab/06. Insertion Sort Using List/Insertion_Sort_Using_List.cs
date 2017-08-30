using System;
using System.Linq;

namespace _06.Insertion_Sort_Using_List
{
    public class Insertion_Sort_Using_List
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

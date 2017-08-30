using System;
using System.Linq;

namespace _05.Compare_Char_Arrays_second_way
{
    public class Compare_Char_Arrays_second_way
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            string[] arrays = {new string(firstArray), new string(secondArray)};

            Console.WriteLine(string.Join("\n", arrays.OrderBy(str => str)));
        }
    }
}

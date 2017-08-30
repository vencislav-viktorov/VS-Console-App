using System;
using System.Linq;

namespace _05.CompareCharArrays_third_way
{
    public class CompareCharArrays_third_way
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            string[] arrays = {new string(firstArray), new string(secondArray)};

            Array.Sort(arrays);

            Console.WriteLine(string.Join("\n", arrays));
        }
    }
}

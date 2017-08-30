using System;

namespace _06.Reverse_Array_of_Strings_second_way
{
    public class Reverse_Array_of_Strings_second_way
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split(' ');

            Array.Reverse(array);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}

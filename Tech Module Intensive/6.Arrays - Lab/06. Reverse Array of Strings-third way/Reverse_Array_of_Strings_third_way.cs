using System;

namespace _06.Reverse_Array_of_Strings_third_way
{
    public class Reverse_Array_of_Strings_third_way
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split(' ');
           
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

using System;

namespace _04.Rotate_Array_of_Strings___forthway
{
    public class Rotate_Array_of_Strings___forthway
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine()
                .Split(' ');

            string currentElement = arr[arr.Length - 1];

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                string temp = arr[cnt];

                arr[cnt] = currentElement;

                currentElement = temp;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

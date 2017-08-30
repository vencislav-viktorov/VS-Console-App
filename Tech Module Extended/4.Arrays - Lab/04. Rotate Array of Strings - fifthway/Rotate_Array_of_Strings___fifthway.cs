using System;

namespace _04.Rotate_Array_of_Strings___fifthway
{
    public class Rotate_Array_of_Strings___fifthway
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine()
               .Split(' ');

            string currentElement = arr[arr.Length - 1];

            for (int cnt = arr.Length - 1; cnt > 0; cnt--)
            {
                arr[cnt] = arr[cnt - 1];
            }

            arr[0] = currentElement;

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

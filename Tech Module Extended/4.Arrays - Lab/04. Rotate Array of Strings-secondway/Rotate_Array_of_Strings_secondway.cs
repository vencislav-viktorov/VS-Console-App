using System;

namespace _04.Rotate_Array_of_Strings_secondway
{
    public class Rotate_Array_of_Strings_secondway
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine()
                .Split(' ');

            string[] resultArr = new string[arr.Length];

            for (int cnt = 0; cnt < arr.Length - 1; cnt++)
            {
                resultArr[cnt + 1] = arr[cnt];
            }

            resultArr[0] = arr[arr.Length - 1];

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}

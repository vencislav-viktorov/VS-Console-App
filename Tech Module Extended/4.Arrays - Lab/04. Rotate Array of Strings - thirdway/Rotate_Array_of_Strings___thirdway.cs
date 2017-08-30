using System;

namespace _04.Rotate_Array_of_Strings___thirdway
{
    public class Rotate_Array_of_Strings___thirdway
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine()
                .Split(' ');

            string[] resultArr = new string[arr.Length];

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                resultArr[(cnt + 1) % arr.Length] = arr[cnt];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}

using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] array2 = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string result = string.Empty;

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        result += array2[i] + " ";
                    }
                }
            }

            //string[] stringArray = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join(" ", stringArray));

            Console.WriteLine(result);
        }
    }
}

using System;

namespace _11.GivenElementinArray_secondway
{
    public class GivenElementinArray_secondway
    {
        public static void Main()
        {
            var currentArray = Console.ReadLine().Split();

            var matchSymbol = Console.ReadLine();

            var counter = 0;

            for (int index = 0; index < currentArray.Length; index++)
            {
                if (currentArray[index] == matchSymbol)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

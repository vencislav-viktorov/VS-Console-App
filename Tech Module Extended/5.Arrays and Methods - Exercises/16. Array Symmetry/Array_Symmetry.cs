using System;

namespace _16.Array_Symmetry
{
    public class Array_Symmetry
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(' ');

            var interations = sequence.Length / 2;

            var index = 0;

            var position = sequence.Length - index - 1;

            for (index = 0; index < interations; index++)
            {
                if (sequence[index] != sequence[position])
                {
                    Console.WriteLine("No");

                    return;
                }

                position--;
            }

            Console.WriteLine("Yes");
        }
    }
}

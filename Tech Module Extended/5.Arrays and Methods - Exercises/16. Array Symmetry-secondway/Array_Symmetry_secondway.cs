using System;

namespace _16.Array_Symmetry_secondway
{
    public class Array_Symmetry_secondway
    {
        public static void Main()
        {
            string[] massive = Console.ReadLine().Split(' ');

            int index = 0;

            bool lamp = false;

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] != massive[massive.Length - 1 - index])
                {
                    Console.WriteLine("No");
                    lamp = true;

                    break;
                }

                index++;
            }

            if (lamp == false)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}

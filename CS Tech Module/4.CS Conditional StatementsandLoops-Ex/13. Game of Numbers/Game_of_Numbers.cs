using System;

namespace _13.Game_of_Numbers
{
    public class Game_of_Numbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var m = int.Parse(Console.ReadLine());

            var magicNumber = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNumber}");
                        return;
                    }

                }
            }

            Console.WriteLine("{0} combinations - neither equals {1} ", counter, magicNumber);
        }
    }
}
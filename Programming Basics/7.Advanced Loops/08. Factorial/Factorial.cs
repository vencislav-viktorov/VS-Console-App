using System;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var fact = 1;

            while (n > 1)
            {
                fact *= n;

                n--;
            }

            Console.WriteLine(fact);
        }
    }
}

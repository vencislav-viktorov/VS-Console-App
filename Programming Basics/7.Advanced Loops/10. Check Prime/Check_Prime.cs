using System;

namespace _10.Check_Prime
{
    class Check_Prime
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var prime = true;

            for (var i = 2; i <= Math.Sqrt(n); i++)

                if (n % i == 0)
                {
                    prime = false;

                    break;
                }

            if (prime)
            {
                Console.WriteLine("Prime");
            }

            if (n == 0 && n == 1 && n == -11 && n == -1)
            {
                Console.WriteLine("Not prime");
            }

            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}

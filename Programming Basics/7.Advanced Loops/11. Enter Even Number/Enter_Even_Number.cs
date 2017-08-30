using System;

namespace _11.Enter_Even_Number
{
    class Enter_Even_Number
    {
        static void Main()
        {
            int n;

            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        break;
                    }

                    Console.WriteLine("The number is not even.");

                    n = int.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            while (true);

            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}

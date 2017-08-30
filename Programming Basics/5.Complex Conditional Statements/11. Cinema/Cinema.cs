using System;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string projekciq = Console.ReadLine().ToLower();

            int redove = int.Parse(Console.ReadLine());

            int koloni = int.Parse(Console.ReadLine());
            
            if (projekciq == "premiere")
            {
                Console.WriteLine("{0:F2}", 12 * redove * koloni);
            }

            if (projekciq == "normal")
            {
                Console.WriteLine("{0:F2}", 7.5 * redove * koloni);
            }

            if (projekciq == "discount")
            {
                Console.WriteLine("{0:F2}", 5 * redove * koloni);
            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

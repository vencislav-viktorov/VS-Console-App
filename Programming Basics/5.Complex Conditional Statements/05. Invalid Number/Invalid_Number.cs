using System;

namespace _05.Invalid_Number
{
    class Invalid_Number
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool isvalid =
                number >= 100 && number <= 200 || number == 0;

            if (!isvalid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            var VIPGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                var firstChar = input[0];

                if (input.Length == 8 && char.IsDigit(firstChar))
                {
                    VIPGuests.Add(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (VIPGuests.Contains(input))
                {
                    VIPGuests.Remove(input);
                }
                else
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(VIPGuests.Count + regularGuests.Count);

            if (VIPGuests.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, VIPGuests));
            }

            if (regularGuests.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
            }
        }
    }
}
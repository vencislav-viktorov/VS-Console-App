using System;
using System.Collections.Generic;

namespace _03.Mixed_Phones
{
    public class Mixed_Phones
    {
        public static void Main()
        {
            var mixedPhones = Console.ReadLine();

            var phoneBook = new SortedDictionary<string, decimal>();

            while (mixedPhones != "Over")
            {
                var mixedElements = mixedPhones
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                var firstElement = mixedElements[0];

                var lastElement = mixedElements[mixedElements.Length - 1];

                decimal phoneNumber = 0;

                var success = decimal.TryParse(firstElement, out phoneNumber);

                if (success)
                {
                    phoneBook[lastElement] = phoneNumber;
                }

                else
                {
                    phoneNumber = decimal.Parse(lastElement);

                    phoneBook[firstElement] = phoneNumber;
                }

                mixedPhones = Console.ReadLine();
            }

            foreach (var person in phoneBook)
            {
                var name = person.Key;

                var phone = person.Value;

                Console.WriteLine($"{name} -> {phone}");
            }
        }
    }
}

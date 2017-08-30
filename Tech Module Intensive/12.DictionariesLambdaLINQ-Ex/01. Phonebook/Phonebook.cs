using System;
using System.Collections.Generic;

namespace _01.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] entryForPhonebook = Console.ReadLine().Split();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (entryForPhonebook[0] != "END")
            {
                if (entryForPhonebook[0] == "A")
                {
                    phonebook[entryForPhonebook[1]] = entryForPhonebook[2];
                }

                else if (entryForPhonebook[0] == "S")
                {
                    if (phonebook.ContainsKey(entryForPhonebook[1]))
                    {
                        Console.WriteLine($"{entryForPhonebook[1]} -> {phonebook[entryForPhonebook[1]]}");
                    }

                    else
                    {
                        Console.WriteLine($"Contact {entryForPhonebook[1]} does not exist.");
                    }
                }

                entryForPhonebook = Console.ReadLine().Split();
            }
        }
    }
}

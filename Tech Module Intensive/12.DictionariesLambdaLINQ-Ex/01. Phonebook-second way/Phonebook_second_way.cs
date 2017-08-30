using System;
using System.Collections.Generic;

namespace _01.Phonebook_second_way
{
    public class Phonebook_second_way
    {
        public static void Main()
        {
            string[] entryForPhonebook = Console.ReadLine().Split();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

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

                else if (entryForPhonebook[0] == "ListAll")
                {
                    foreach (KeyValuePair<string, string> pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                entryForPhonebook = Console.ReadLine().Split();
            }
        }
    }
}

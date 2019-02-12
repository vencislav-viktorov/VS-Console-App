using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, string> morse = new Dictionary<string, string>()
                                   {
                                       {".-", "A"},
                                       {"-...", "B"},
                                       {"-.-.", "C"},
                                       {"-..", "D"},
                                       {".", "E"},
                                       {"..-.", "F"},
                                       {"--.", "G"},
                                       {"....", "H"},
                                       {"..", "I"},
                                       {".---", "J"},
                                       {"-.-", "K"},
                                       {".-..", "L"},
                                       {"--", "M"},
                                       {"-.", "N"},
                                       {"---", "O"},
                                       {".--.", "P"},
                                       {"--.-", "Q"},
                                       {".-.", "R"},
                                       {"...", "S"},
                                       {"-", "T"},
                                       {"..-", "U"},
                                       {"...-", "V"},
                                       {".--", "W"},
                                       {"-..-", "X"},
                                       {"-.--", "Y"},
                                       {"--..", "Z"},
                                       {"-----", "0"},
                                       {".----", "1"},
                                       {"..---", "2"},
                                       {"...--", "3"},
                                       {"....-", "4"},
                                       {".....", "5"},
                                       {"-....", "6"},
                                       {"--...", "7"},
                                       {"---..", "8"},
                                       {"----.", "9"}
                                   };

            string[] userInput = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < userInput.Length; i++)
            {
                var currentLetter = userInput[i];

                if (currentLetter == "|")
                {
                    Console.Write(" ");
                    continue;
                }

                if (morse.ContainsKey(currentLetter))
                {
                    Console.Write(morse[currentLetter]);
                }
            }

            Console.WriteLine();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string firstPattern = @"([#$%*&])(?<capitalLetters>[A-Z]+)(\1)";
            Match firstMatch = Regex.Match(firstPart, firstPattern);
            string letters = firstMatch.Groups["capitalLetters"].Value;

            for (int i = 0; i < letters.Length; i++)
            {
                char currentLetter = letters[i];
                int asciiCode = currentLetter;

                string secondPattern = $@"{asciiCode}:(?<length>[0-9][0-9])";
                Match secondMatch = Regex.Match(secondPart, secondPattern);
                int length = int.Parse(secondMatch.Groups["length"].Value);

                string thirdPattern = $@"(?<=\s|^){currentLetter}[^\s]{{{length}}}(?=\s|$)";
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
                string word = thirdMatch.ToString();

                Console.WriteLine(word);

            }
        }
    }
}

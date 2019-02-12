using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace _10._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            Regex regex = new Regex(@".+?[0-9]+");

            var matches = regex.Matches(input);

            StringBuilder result = new StringBuilder();

            int counter = 0;

            List<string> text = new List<string>();
            
            List<char> symbol = new List<char>();

            foreach (Match item in matches)
            {
                text.Add(item.Value);
            }

            for (int i = 0; i < text.Count; i++)
            {
                StringBuilder currentText = new StringBuilder();

                string numberAstext = string.Empty;

                for (int j = 0; j < text[i].Length; j++)
                {
                    if (text[i][j] >= 48 && text[i][j] <= 57)
                    {
                        numberAstext += text[i][j] - 48;
                    }

                    else
                    {
                        currentText.Append(text[i][j]);

                        if (!symbol.Contains(text[i][j]) && !text[i].EndsWith("0"))
                        {
                            symbol.Add(text[i][j]);

                            counter++;
                        }

                    }
                }

                int number = int.Parse(numberAstext);

                for (int k = 0; k < number; k++)
                {
                    result.Append(currentText);
                }
            }

            Console.WriteLine($"Unique symbols used: {counter}");

            Console.WriteLine(result);
        }
    }
}

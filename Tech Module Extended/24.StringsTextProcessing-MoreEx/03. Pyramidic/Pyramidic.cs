using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var inputStrings = new List<string>();

            // Creating Collection from input strings:

            for (int linesToInput = 0; linesToInput < numberOfLines; linesToInput++)
            {
                var currentString = Console.ReadLine();

                inputStrings.Add(currentString);
            }

            // Cheking for chars in increacing sequence , +2 for each next string:

            var index = 0;

            var newStr = 1;

            var pyramids = new List<string>();

            while (index < inputStrings.Count - 1)
            {
                var currentString = inputStrings[index];

                foreach (var item in currentString)
                {
                    foreach (var sequence in inputStrings.Skip(index + 1))
                    {
                        var str = new string(item, newStr + 2);

                        if (sequence.Contains(str))
                        {
                            if (sequence == inputStrings[inputStrings.Count - 1])
                            {
                                pyramids.Add(str);
                            }

                            newStr += 2;
                        }

                        else
                        {
                            pyramids.Add(new string(item, newStr)); break;
                        }
                    }

                    newStr = 1;
                }
                index++;
            }

            // Printing the result:

            pyramids = pyramids.OrderByDescending(x => x.Length).ToList();

            var winer = pyramids[0];

            for (int i = 1; i <= winer.Length; i += 2)
            {
                Console.WriteLine(new string(winer[0], i));
            }
        }
    }
}

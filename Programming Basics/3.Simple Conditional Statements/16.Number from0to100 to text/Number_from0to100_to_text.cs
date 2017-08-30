using System;

namespace _16.Number_from0to100_to_text
{
    class Number_from0to100_to_text
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] shortName = new string[] { "zero", "one", "two",
                "three", "four", "five", "six", "seven", "eight", "nine",
                "number too big", "eleven", "twelve" };

            string[] compositeName = new string[] { "twen", "thir", "four",
                "fif", "six", "seven", "eigh", "nine" };

            string name = "";

            if ((number < 0) || (number > 100))
            {
                name = "number too big";
            }

            else if (number < 13)
            {
                name = shortName[number];
            }

            else if (number < 20)
            {
                name = compositeName[number % 10 - 2] + "teen";
            }

            else if (number < 100)
            {
                if (number / 10 == 4)
                {
                    name = "forty";
                }

                else
                {
                    name = compositeName[number / 10 - 2] + "ty";
                }

                if (number % 10 != 0)
                {
                    name += " " + shortName[number % 10];
                }
            }

            else
            {
                name = "one hundred";
            }

            Console.WriteLine(name);
        }
    }
}

using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                bool isBoolean = bool.TryParse(line, out bool boolean);
                bool isInteger = int.TryParse(line, out int integer);
                bool isCharacter = char.TryParse(line, out char character);
                bool isDouble = double.TryParse(line, out double floatingPoint);

                if (isBoolean)
                {
                    Console.WriteLine($"{line} is boolean type");
                }

                else if (isInteger)
                {
                    Console.WriteLine($"{line} is integer type");

                }

                else if (isCharacter)
                {
                    Console.WriteLine($"{line} is character type");

                }

                else if (isDouble)
                {
                    Console.WriteLine($"{line} is floating point type");

                }

                else
                {
                    Console.WriteLine($"{line} is string type");
                }
            }
        }
    }
}

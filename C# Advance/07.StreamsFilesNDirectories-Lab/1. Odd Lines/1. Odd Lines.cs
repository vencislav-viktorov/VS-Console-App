using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader(@"../../../Resources/Input.txt"))
            {
                int counter = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }
            }
        }
    }
}

using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader(@"../../../Resources/text.txt"))
            {
                var counter = 1;

                using (var writer = new StreamWriter(@"../../../Output.txt"))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        int lettersCount = 0;
                        int symbolCount = 0;

                        if (counter != 1)
                        {
                            writer.WriteLine();
                        }

                        foreach (var @char in line)
                        {
                            if (char.IsLetter(@char))
                            {
                                lettersCount++;
                            }
                            else if (char.IsPunctuation(@char))
                            {
                                symbolCount++;
                            }
                        }

                        writer.Write($"Line {counter}: {line} ({lettersCount})({symbolCount})");

                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

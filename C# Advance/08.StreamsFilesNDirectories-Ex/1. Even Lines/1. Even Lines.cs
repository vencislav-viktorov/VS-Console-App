using System;
using System.IO;
using System.Linq;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main()
        {
            var specialSymbols = "-,.!?";

            var counter = 0;

            using (var reader = new StreamReader(@"../../../Resources/text.txt"))
            {
                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }


                        if (counter % 2 == 0)
                        {
                            if (counter != 0)
                            {
                                writer.WriteLine();
                            }

                            var changeLine = string.Empty;

                            foreach (var charr in line)
                            {
                                if (specialSymbols.Contains(charr))
                                {
                                    changeLine += '@';
                                }
                                else
                                {
                                    changeLine += charr;
                                }
                            }

                            var splitedLine = changeLine.Split();

                            Array.Reverse(splitedLine);

                            writer.Write(string.Join(" ", splitedLine));
                        }

                        counter++;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _04.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            while (inputString != "end")
            {
                var firstCount = 0;

                var lastCount = inputString.Length - 1;

                var core = string.Empty;

                var nilapdroms = new List<string>();

                while (firstCount <= inputString.Length / 2)
                {
                    var firstBorder = inputString.Substring(0, firstCount + 1);

                    var lastBorder = inputString.Substring(lastCount - firstCount, firstCount + 1);

                    if (firstBorder == lastBorder)
                    {
                        core = firstBorder;

                        var newNilapdrom = Nilapdrom(inputString, firstCount + 1);

                        if (newNilapdrom != string.Empty)
                        {
                            nilapdroms.Add(newNilapdrom + core + newNilapdrom);
                        }
                    }

                    firstCount++;
                }

                if (nilapdroms.Count > 0)
                {
                    Console.WriteLine(nilapdroms[nilapdroms.Count - 1]);
                }

                inputString = Console.ReadLine();
            }
        }

        private static string Nilapdrom(string inputString, int v)
        {
            var core = string.Empty;

            for (int i = v; i < inputString.Length - v; i++)
            {
                core += inputString[i];
            }

            return core;
        }
    }
}

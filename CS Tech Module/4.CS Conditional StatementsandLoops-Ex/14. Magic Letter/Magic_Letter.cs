using System;

namespace _14.Magic_Letter
{
    public class Magic_Letter
    {
        public static void Main()
        {
            char firstLine = char.Parse(Console.ReadLine());

            char secondLine = char.Parse(Console.ReadLine());

            char thirdLine = char.Parse(Console.ReadLine());

            for (char i = firstLine; i <= secondLine; i++)
            {
                for (char j = firstLine; j <= secondLine; j++)
                {
                    for (char k = firstLine; k <= secondLine; k++)
                    {
                        if (i != thirdLine && j != thirdLine && k != thirdLine)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}

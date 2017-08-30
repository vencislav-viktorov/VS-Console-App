using System;

namespace _06.DNA_Sequences
{
    public class DNA_Sequences
    {
        public static void Main()
        {
            int sum = int.Parse(Console.ReadLine());

            int count = 0;

            for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
            {
                for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
                {
                    for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                    {
                        count ++;

                        if (firstLetter + secondLetter + thirdLetter >= sum)
                        {
                            Console.Write("O" + 
                                ("" + firstLetter + secondLetter + thirdLetter)
                                .Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') 
                                + "O ");
                        }

                        else
                        {
                            Console.Write("X" +
                                ("" + firstLetter + secondLetter + thirdLetter)
                                .Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T')
                                + "X ");
                        }

                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
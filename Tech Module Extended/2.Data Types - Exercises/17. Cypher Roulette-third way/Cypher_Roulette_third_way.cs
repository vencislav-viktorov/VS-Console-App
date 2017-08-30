using System;

namespace _17.Cypher_Roulette_third_way
{
    public class Cypher_Roulette_third_way
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isReversed = false;

            string message = String.Empty;

            string previousString = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString == previousString)
                {
                    message = String.Empty;

                    if (currentString == "spin")
                    {
                        i--;
                    }
                }

                else
                {
                    if (currentString == "spin")
                    {
                        isReversed = !isReversed;

                        i--;
                    }

                    else
                    {
                        if (isReversed)
                        {
                            message = currentString + message;
                        }
                        else
                        {
                            message += currentString;
                        }
                    }

                }

                previousString = currentString;
            }

            Console.WriteLine(message);
        }
    }
}

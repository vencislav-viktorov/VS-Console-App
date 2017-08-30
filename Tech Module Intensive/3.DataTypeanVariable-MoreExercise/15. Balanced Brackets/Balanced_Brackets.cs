using System;

namespace _15.Balanced_Brackets
{
    public class Balanced_Brackets
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            string lastBracket = string.Empty;

            string balance = "BALANCED";

            for (int i = 0; i < numberOfInputs; i++)
            {
                string currentInput = Console.ReadLine();

                if (currentInput == "(")
                {
                    if (lastBracket == "(")
                    {
                        balance = "UNBALANCED";

                        break;
                    }

                    lastBracket = "(";
                }

                if (currentInput == ")")
                {
                    if (lastBracket != "(")
                    {
                        balance = "UNBALANCED";

                        break;
                    }

                    lastBracket = ")";
                }
            }

            if (lastBracket == "(")
            {
                balance = "UNBALANCED";
            }

            Console.WriteLine(balance);
        }
    }
}

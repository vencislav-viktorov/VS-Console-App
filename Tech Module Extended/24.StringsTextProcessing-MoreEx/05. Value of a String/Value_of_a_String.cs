using System;

namespace _05.Value_of_a_String
{
    public class StringValue
    {
        static int upperCaseSymbols;

        static int lowerCaseSymbols;

        public static void Main()
        {
            var someStringAsCharCollection = Console.ReadLine();

            var asciiSumUpperOrLowerCase = Console.ReadLine();

            SumAllLettersFromUpperAndLowerCase(someStringAsCharCollection);

            PrintResultByGivenASCIISumOperatorFrom(asciiSumUpperOrLowerCase);
        }

        static void PrintResultByGivenASCIISumOperatorFrom(string asciiSumUpperOrLowerCase)
        {
            Console.WriteLine(asciiSumUpperOrLowerCase == "LOWERCASE" ?
                $"The total sum is: {lowerCaseSymbols}" :
                $"The total sum is: {upperCaseSymbols}");
        }

        static void SumAllLettersFromUpperAndLowerCase(string someStringAsCharCollection)
        {
            foreach (var letter in someStringAsCharCollection)
            {
                if (letter >= 'a' && letter <= 'z')
                {
                    lowerCaseSymbols += letter;
                }

                else if (letter >= 'A' && letter <= 'Z')
                {
                    upperCaseSymbols += letter;
                }
            }
        }
    }
}

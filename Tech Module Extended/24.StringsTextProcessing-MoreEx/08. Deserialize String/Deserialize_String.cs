using System;

namespace _08.Deserialize_String
{
    public class DeserializeString
    {
        static char currentSymbol;

        static int[] givenIndexes;

        static int maxIndex;

        static int splitSimbolCount = 0;

        static string outputString = string.Empty;

        public static void Main()
        {
            ReadNextStringsFrom($@"{Console.ReadLine()}");

            Console.WriteLine(outputString);
        }

        static void ReadNextStringsFrom(string partOfResultString)
        {
            if (partOfResultString != "end")
            {
                DivideAndRule(partOfResultString);

                ReadNextStringsFrom($@"{Console.ReadLine()}");
            }

            else return;
        }

        static void DivideAndRule(string partOfResultString)
        {
            var pattern = new[] { ":", "/" };

            var splited = partOfResultString.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

            currentSymbol = splited[0][0];

            ConvertToIntegers(splited);

            MakeTemporaryOutputString();

            ReplaceAllGivenIndexesWhithCurrentSymbol();
        }

        static void ConvertToIntegers(string[] splited)
        {
            maxIndex = int.MinValue;

            givenIndexes = new int[splited.Length - 1];

            for (int index = 1; index <= splited.Length - 1; index++)
            {
                givenIndexes[index - 1] = Convert.ToInt32(splited[index]);

                if (givenIndexes[index - 1] > maxIndex)
                {
                    maxIndex = givenIndexes[index - 1];
                }
            }
        }

        static void MakeTemporaryOutputString()
        {
            var counter = outputString.Length - splitSimbolCount;

            for (int index = counter; index <= maxIndex; index++)
            {
                outputString += $"|{index}|";

                splitSimbolCount += index > 99 ? 4 : index > 9 ? 3 : 2;
            }
        }

        static void ReplaceAllGivenIndexesWhithCurrentSymbol()
        {
            foreach (var index in givenIndexes)
            {
                outputString = outputString.Replace($"|{index}|", currentSymbol.ToString());

                splitSimbolCount -= index > 99 ? 4 : index > 9 ? 3 : 2;
            }
        }
    }
}

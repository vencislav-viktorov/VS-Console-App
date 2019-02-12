using System;

namespace _01._EncryptSortNPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfString = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfString];

            for (int i = 0; i < numberOfString; i++)
            {
                string input = Console.ReadLine();

                int sum = 0;
                
                for (int j = 0; j < input.Length; j++)
                {
                    char letter = input[j];
                    int multipliedOrDivided = input.Length;

                    if (letter == 'a' || letter == 'e' ||
                        letter == 'i' || letter == 'o' ||
                        letter == 'u' || letter == 'A' ||
                        letter == 'E' || letter == 'I' ||
                        letter == 'O' || letter == 'U')
                    {
                        sum += letter * multipliedOrDivided;
                    }

                    else
                    {
                        sum += letter / multipliedOrDivided;
                    }
                }

                numbers[i] = sum;
                sum = 0;
            }

            Array.Sort(numbers);
            Console.Write(string.Join(Environment.NewLine, numbers));
            Console.WriteLine();
        }
    }
}

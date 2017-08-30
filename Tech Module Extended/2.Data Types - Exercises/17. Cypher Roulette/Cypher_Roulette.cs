using System;

namespace _17.Cypher_Roulette
{
    public class Cypher_Roulette
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            string lastStr = string.Empty;

            bool addToEnd = true;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals(lastStr))
                {
                    if (str.Equals("spin"))
                    {
                        result = string.Empty;

                        i--;

                        continue;
                    }

                    result = string.Empty;

                    continue;
                }

                lastStr = str;

                if (str.Equals("spin"))
                {
                    addToEnd = !addToEnd;

                    i--;
                }

                else if (addToEnd == true)
                {
                    result += str;
                }

                else if (addToEnd == false)
                {
                    result = str + result;
                }
            }

            Console.WriteLine(result);
        }

        static string ConcatenateText(int number)
        {
            string concatinatedText = null;

            string command = null;

            string repetedText = null;

            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();

                if (repetedText != text)
                {
                    if (command == "spin")
                    {
                        if (text == "spin")
                        {
                            i--;
                            command = null;
                        }

                        else
                        {
                            concatinatedText = text + concatinatedText;
                        }

                    }

                    else if (text == "spin")
                    {
                        i--;

                        command = "spin";
                    }

                    else
                    {
                        concatinatedText += text;
                    }
                }

                else
                {
                    if (text == "spin")
                    {
                        i--;

                        command = null;

                        concatinatedText = null;
                    }

                    concatinatedText = null;
                }

                repetedText = text;
            }

            return concatinatedText;
        }
    }
}
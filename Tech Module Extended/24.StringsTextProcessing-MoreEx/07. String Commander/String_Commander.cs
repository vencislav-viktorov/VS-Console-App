using System;
using System.Text;

namespace _07.String_Commander
{
    public class StringCommander
    {
        static string action;

        static string word;

        static int index;

        static int count;

        static StringBuilder stringBuilder = new StringBuilder();

        public static void Main()
        {
            stringBuilder = stringBuilder.Append($@"{Console.ReadLine()}");

            ReadNextCommandsUntillEnd($@"{Console.ReadLine()}");

            Console.WriteLine(stringBuilder);
        }

        private static void ReadNextCommandsUntillEnd(string currentComand)
        {
            if (currentComand != "end")
            {
                DivideAndRule(currentComand);

                PripareToChahgeWorkString();

                ReadNextCommandsUntillEnd($@"{Console.ReadLine()}");
            }

            else return;
        }

        static void DivideAndRule(string currentComand)
        {
            var splited = currentComand.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            action = splited[0];

            index = Convert.ToInt32(splited[1]);

            if (splited.Length > 2)
            {
                NumberOrString(splited[2]);
            }
        }

        static void NumberOrString(string x)
        {
            count = 0;

            if (!int.TryParse(x, out count))
            {
                word = x;
            }
        }

        static void PripareToChahgeWorkString()
        {
            if (action == "Delete")
            {
                DeleteFromStringBuilder();
            }

            if (action == "Insert")
            {
                InsertInStringBuilder();
            }

            if (action == "Left")
            {
                MoveLeft();
            }

            if (action == "Right")
            {
                MoveRight();
            }
        }

        private static void DeleteFromStringBuilder()
        {
            if (count + 1 > stringBuilder.Length - 1)
            {
                stringBuilder.Remove(index, stringBuilder.Length - index);
            }

            else stringBuilder.Remove(index, count + 1);
        }

        private static void InsertInStringBuilder()
        {
            if (index <= stringBuilder.Length - 1)
            {
                stringBuilder.Insert(index, word);
            }

            else stringBuilder.Append(word);
        }

        static void MoveLeft()
        {
            var substringIndex = index % stringBuilder.Length;

            var first = stringBuilder.ToString().Substring(0, substringIndex);

            stringBuilder = stringBuilder.Remove(0, substringIndex);

            stringBuilder = stringBuilder.Append(first);
        }

        static void MoveRight()
        {
            var substringIndex = stringBuilder.Length - index % stringBuilder.Length;

            var first = stringBuilder.ToString().Substring(0, substringIndex);

            stringBuilder = stringBuilder.Remove(0, substringIndex);

            stringBuilder = stringBuilder.Append(first);
        }
    }
}

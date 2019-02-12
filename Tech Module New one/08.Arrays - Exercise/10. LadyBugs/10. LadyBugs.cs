using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            string[] indexes = Console.ReadLine()
                .Split();

            int[] field = new int[fieldSize];

            for (int i = 0; i < indexes.Length; i++)
            {
                int index = int.Parse(indexes[i]);

                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                int index = int.Parse(cmdArgs[0]);
                string cmd = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (index < 0 || index > fieldSize - 1 || field[index] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                field[index] = 0;

                if (cmd == "right")
                {

                    index += flyLength;

                    while (index < fieldSize && field[index] == 1)
                    {
                        index += flyLength;
                    }

                    if (index < fieldSize)
                    {
                        field[index] = 1;
                    }
                }

                else
                {
                    index -= flyLength;

                    while (index >= 0 && field[index] == 1)
                    {
                        index -= flyLength;
                    }

                    if(index >= 0)
                    {
                        field[index] = 1;
                    }
                }

                command = Console.ReadLine();
            }

            for (int k = 0; k < field.Length; k++)
            {
                Console.Write(field[k] + " ");
            }

            Console.WriteLine();
        }
    }
}

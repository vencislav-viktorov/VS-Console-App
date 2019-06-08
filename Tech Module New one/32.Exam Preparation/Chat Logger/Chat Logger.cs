using System;
using System.Collections.Generic;

namespace Chat_Logger
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {

                    case "Chat":
                        list.Add(command[1]);
                        break;

                    case "Delete":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == command[1])
                            {
                                list.Remove(command[1]);
                            }
                        }
                        break;

                    case "Edit":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == command[1])
                            {
                                list[i] = list[i].Replace(command[1], command[2]);
                            }
                        }
                        break;

                    case "Pin":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == command[1])
                            {
                                list.Add(command[1]);
                                list.Remove(command[1]);
                                break;
                            }
                        }
                        break;

                    case "Spam":
                        for (int i = 1; i < command.Length; i++)
                        {
                            list.Add(command[i]);
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join("\n", list));
        }
    }
}

using System;

namespace _03._Extract_File_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split('\\', '.');

            Console.WriteLine($"File name: {text[text.Length - 2]}");
            Console.WriteLine($"File extension: {text[text.Length - 1]}");
        }
    }
}

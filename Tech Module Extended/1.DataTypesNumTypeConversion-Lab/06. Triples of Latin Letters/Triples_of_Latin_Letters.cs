using System;

namespace _06.Triples_of_Latin_Letters
{
    public class Triples_of_Latin_Letters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < n + 'a'; i++)
            {
                for (char j = 'a'; j < n + 'a'; j++)
                {
                    for (char k = 'a'; k < n + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
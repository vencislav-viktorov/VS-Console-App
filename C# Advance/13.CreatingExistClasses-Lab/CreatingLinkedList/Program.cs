﻿namespace CreatingLinkedList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var linkedList = new CoolLinkedList();

            linkedList.AddHead(5);
            linkedList.AddHead(10);
            linkedList.AddHead(15);

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 5);
            Console.WriteLine(linkedList.Count == 3);

            linkedList.AddTail(20);
            linkedList.AddTail(25);

            linkedList.ForEach(Console.WriteLine);

            Console.WriteLine();

            var arr = linkedList.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 25);
            Console.WriteLine(linkedList.Count == 5);

            Console.WriteLine((int)linkedList.RemoveHead() == 15);
            Console.WriteLine((int)linkedList.RemoveHead() == 10);
            Console.WriteLine((int)linkedList.Head == 5);
            Console.WriteLine(linkedList.Count == 3);

            Console.WriteLine((int)linkedList.RemoveTail() == 25);
            Console.WriteLine((int)linkedList.RemoveTail() == 20);
            Console.WriteLine((int)linkedList.RemoveTail() == 5);
            Console.WriteLine(linkedList.Count == 0);

            try
            {
                Console.WriteLine(linkedList.Head);
                Console.WriteLine(false);
            }
            catch (InvalidOperationException)
            {

                Console.WriteLine(true);
            }

            linkedList = new CoolLinkedList();

            linkedList.AddTail(5);
            linkedList.AddTail(10);
            linkedList.AddTail(5);
            linkedList.AddTail(20);
            linkedList.AddTail(5);

            linkedList.Remove(5);

            Console.WriteLine((int)linkedList.Head == 10);
            Console.WriteLine((int)linkedList.Tail == 20);
            Console.WriteLine(linkedList.Count == 2);

            Console.WriteLine();

            Console.WriteLine(linkedList.Contains(10));
            Console.WriteLine(linkedList.Contains(20));
            Console.WriteLine(linkedList.Contains(5) == false);

            Console.WriteLine();

            linkedList.Clear();
            Console.WriteLine(linkedList.Count == 0);
            Console.WriteLine(linkedList.Contains(10) == false);
            Console.WriteLine(linkedList.Contains(20) == false);

        }
    }
}

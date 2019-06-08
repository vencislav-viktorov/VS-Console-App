namespace CollectionHierarchy
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var mylist = new MyList();

            var input = Console.ReadLine()
                .Split();

            foreach (var item in input)
            {
                Console.Write($"{addCollection.Add(item)} ");
            }

            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write($"{addRemoveCollection.Add(item)} ");
            }

            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write($"{mylist.Add(item)} ");
            }

            Console.WriteLine();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{addRemoveCollection.Remove()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{mylist.Remove()} ");
            }

            Console.WriteLine();
        }
    }
}
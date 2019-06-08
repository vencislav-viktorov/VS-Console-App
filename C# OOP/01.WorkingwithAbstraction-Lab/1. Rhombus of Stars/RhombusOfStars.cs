namespace RhombusOfStars
{
    using System;

    public class RhombusOfStars
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            PrintUpper(size);

            PrintLower(size);
        }

        public static void PrintUpper(int size)
        {
            for (int startCount = 1; startCount <= size; startCount++)
            {
                PrintRow(size, startCount);
            }
        }

        public static void PrintLower(int size)
        {
            for (int startCount = size - 1; startCount >= 1; startCount--)
            {
                PrintRow(size, startCount);
            }
        }

        public static void PrintRow(int figureSize, int startCount)
        {
            for (int i = 0; i < figureSize - startCount; i++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col < startCount; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}

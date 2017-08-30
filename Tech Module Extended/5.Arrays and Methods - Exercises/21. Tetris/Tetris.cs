using System;

namespace _21.Tetris
{
    public class Tetris
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string currentDirection = string.Empty;

            while (currentDirection != "exit")
            {
                currentDirection = Console.ReadLine().ToLower();

                switch (currentDirection)
                {
                    case "left":
                        Left(n);
                        break;

                    case "down":
                        Down(n);
                        break;

                    case "right":
                        Right(n);
                        break;

                    case "up":
                        Up(n);
                        break;
                }
            }
        }

        static void Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }
        }

        static void Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }
        }

        static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }
        }

        static void Down(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
        }
    }
}

namespace SimpleSnake.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SimpleSnake.GameObjects;

    public class DrawManager
    {
        private const string SnakeSymbol = "\u25CF";
        private readonly List<Cordinate> snakeBodyElements;

        public DrawManager()
        {
            this.snakeBodyElements = new List<Cordinate>();
        }

        public void Draw(string symbol, IEnumerable<Cordinate> cordinates)
        {
            foreach (var cordinate in cordinates)
            {
                if (symbol == SnakeSymbol)
                {
                    snakeBodyElements.Add(cordinate);
                }

                Console.SetCursorPosition(cordinate.CordinateX, cordinate.CordinateY);
                Console.Write(symbol);
            }
        }

        public void UndoDraw()
        {
            Cordinate lastElement = this.snakeBodyElements.First();

            Console.SetCursorPosition(lastElement.CordinateX, lastElement.CordinateY);
            Console.Write(" ");

            this.snakeBodyElements.Clear();
        }
    }
}
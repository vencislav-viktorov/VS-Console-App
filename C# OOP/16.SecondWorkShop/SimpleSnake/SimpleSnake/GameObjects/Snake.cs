namespace SimpleSnake.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SimpleSnake.Constants;
    using SimpleSnake.Enums;
    using SimpleSnake.GameObjects.Foods;

    public class Snake
    {
        private readonly List<Cordinate> snakeBody;

        public Snake()
        {
            this.snakeBody = new List<Cordinate>();
            this.Direction = Direction.Right;
            this.InitialiseBody();
        }

        public Cordinate Head => this.snakeBody.Last();

        public Direction Direction { get; set; }

        public IReadOnlyCollection<Cordinate> Body
            => this.snakeBody.AsReadOnly();

        public void Move()
        {
            Cordinate newHead = this.GetNewHeadCordinate();

            this.snakeBody.Add(newHead);
            this.snakeBody.RemoveAt(0);
        }

        private Cordinate GetNewHeadCordinate()
        {
            Cordinate newHeadCordinate = new Cordinate(this.Head.CordinateX, this.Head.CordinateY);

            switch (this.Direction)
            {
                case Direction.Right:
                    newHeadCordinate.CordinateX++;
                    break;

                case Direction.Left:
                    newHeadCordinate.CordinateX--;
                    break;

                case Direction.Down:
                    newHeadCordinate.CordinateY++;
                    break;

                case Direction.Up:
                    newHeadCordinate.CordinateY--;
                    break;
            }

            return newHeadCordinate;
        }

        public void Eat(Food food)
        {
            for (int i = 0; i < food.Points; i++)
            {
                Cordinate newHeadCordinate = this.GetNewHeadCordinate();
                this.snakeBody.Add(newHeadCordinate);
            }
        }

        private void InitialiseBody()
        {
            int x = GameConstant.Snake.DefaultX;
            int y = GameConstant.Snake.DefaultY;

            for (int i = 0; i <= GameConstant.Snake.DefaultLength; i++)
            {
                this.snakeBody.Add(new Cordinate(x, y));
                x++;
            }
        }
    }
}
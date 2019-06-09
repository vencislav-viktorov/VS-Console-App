namespace SimpleSnake.Core
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using SimpleSnake.Constants;
    using SimpleSnake.Enums;
    using SimpleSnake.Factories;
    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.Foods;

    public class Engine
    {
        private readonly DrawManager drawManager;
        private readonly Snake snake;
        private Food food;
        private readonly Cordinate boardCordinate;
        private int gameScore;

        public Engine(DrawManager drawManager, Snake snake, Cordinate boardCordinate)
        {
            this.drawManager = drawManager;
            this.snake = snake;
            this.boardCordinate = boardCordinate;
            this.InitializeFood();
            this.InitializeBoarders();
        }

        public void Run()
        {
            while (true)
            {
                this.PlayerInfo();

                if (Console.KeyAvailable)
                {
                    this.SetCorrectDirection(Console.ReadKey());
                }

                this.drawManager.Draw(food.Symbol, new List<Cordinate> { food.Cordinate });

                this.drawManager.Draw(GameConstant.Snake.Symbol, this.snake.Body);

                this.snake.Move();

                this.drawManager.UndoDraw();

                if (HasFoodCollision())
                {
                    this.snake.Eat(this.food);
                    this.gameScore += this.food.Points;
                    this.InitializeFood();
                }

                if (HasBorderCollision())
                {
                    this.AskPlayerForRestart();
                }

                Thread.Sleep(150);
            }
        }

        private void PlayerInfo()
        {
            int x = GameConstant.Board.DefaultBoardWidth + GameConstant.Player.PlayerScoreOffsetX;
            int y = GameConstant.Player.PlayerScoreOffsetY;

            Console.SetCursorPosition(x, y);

            Console.Write(string.Format(GameConstant.Player.PlayerScore, this.gameScore));
        }

        private void AskPlayerForRestart()
        {
            Console.SetCursorPosition(GameConstant.Config.EndMessageX,
                GameConstant.Config.EndMessageY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(GameConstant.Config.EndMessage);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(GameConstant.Config.EndMessageOption);

            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                Console.Clear();
                StartUp.Main();
            }

            else
            {
                return;
            }
        }

        private bool HasBorderCollision()
        {
            int snakeHeadCordinateX = this.snake.Head.CordinateX;
            int snakeHeadCordinateY = this.snake.Head.CordinateY;

            int boardCordinateX = this.boardCordinate.CordinateX;
            int boardCordinateY = this.boardCordinate.CordinateY;

            return snakeHeadCordinateX == boardCordinateX - 1
                || snakeHeadCordinateX == 0
                || snakeHeadCordinateY == boardCordinateY
                || snakeHeadCordinateY == 0;
        }

        private void InitializeBoarders()
        {
            var allCordinates = new List<Cordinate>();

            this.InitializeHorizontalBorderCordinates(0, allCordinates);
            this.InitializeHorizontalBorderCordinates(this.boardCordinate.CordinateY, allCordinates);

            this.InitializeVerticalBorderCordinates(0, allCordinates);
            this.InitializeVerticalBorderCordinates(this.boardCordinate.CordinateX - 1, allCordinates);

            this.drawManager.Draw(GameConstant.Board.DefaultBoarderSymbol, allCordinates);
        }

        private void InitializeVerticalBorderCordinates(int cordinateX, List<Cordinate> allCordinates)
        {
            for (int cordinateY = 0; cordinateY < this.boardCordinate.CordinateY; cordinateY++)
            {
                allCordinates.Add(new Cordinate(cordinateX, cordinateY));
            }
        }

        private void InitializeHorizontalBorderCordinates(int cordinateY, List<Cordinate> allCordinates)
        {
            for (int cordinateX = 0; cordinateX < this.boardCordinate.CordinateX; cordinateX++)
            {
                allCordinates.Add(new Cordinate(cordinateX, cordinateY));
            }
        }

        private void InitializeFood()
        {
            this.food = FoodFactory.GetRandomFood(this.boardCordinate.CordinateX, this.boardCordinate.CordinateY);
        }

        private bool HasFoodCollision()
        {
            int snakeHeadCordinateX = this.snake.Head.CordinateX;
            int snakeHeadCordinateY = this.snake.Head.CordinateY;

            int foodCordinateX = this.food.Cordinate.CordinateX;
            int foodCordinateY = this.food.Cordinate.CordinateY;

            return snakeHeadCordinateX == foodCordinateX &&
                snakeHeadCordinateY == foodCordinateY;
        }

        private void SetCorrectDirection(ConsoleKeyInfo input)
        {
            Direction currentSnakeDirection = this.snake.Direction;

            switch (input.Key)
            {
                case ConsoleKey.DownArrow:
                    if (currentSnakeDirection != Direction.Up)
                    {
                        currentSnakeDirection = Direction.Down;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (currentSnakeDirection != Direction.Right)
                    {
                        currentSnakeDirection = Direction.Left;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (currentSnakeDirection != Direction.Left)
                    {
                        currentSnakeDirection = Direction.Right;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (currentSnakeDirection != Direction.Down)
                    {
                        currentSnakeDirection = Direction.Up;
                    }
                    break;
            }

            this.snake.Direction = currentSnakeDirection;
        }
    }
}
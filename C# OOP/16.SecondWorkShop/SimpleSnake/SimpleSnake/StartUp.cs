namespace SimpleSnake
{
    using System;
    using SimpleSnake.Constants;
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using SimpleSnake.Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            DrawManager drawManager = new DrawManager();

            Snake snake = new Snake();

            Cordinate boardCordinate = new Cordinate(GameConstant.Board.DefaultBoardWidth,
                GameConstant.Board.DefaultBoardHeight);

            Engine engine = new Engine(drawManager, snake, boardCordinate);

            engine.Run();
        }
    }
}
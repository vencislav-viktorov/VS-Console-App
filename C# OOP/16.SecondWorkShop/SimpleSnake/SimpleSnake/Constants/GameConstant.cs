namespace SimpleSnake.Constants
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class GameConstant
    {
        public static class Snake
        {
            public static readonly string Symbol = "\u25CF";
            public static readonly int DefaultLength = 6;
            public static readonly int DefaultX = 8;
            public static readonly int DefaultY = 7;
        }

        public static class Food
        {
            public static readonly string AsteriskSymbol = "*";
            public static readonly int AsteriskPoints = 1;

            public static readonly string DollarSymbol = "$";
            public static readonly int DollarPoints = 2;

            public static readonly string HashSymbol = "#";
            public static readonly int HashPoints = 3;
        }

        public static class Board
        {
            public static readonly int DefaultBoardWidth = 120;
            public static readonly int DefaultBoardHeight = 40;
            public static readonly string DefaultBoarderSymbol = "\u2588";
        }

        public static class Player
        {
            public static readonly int PlayerScoreOffsetX = 10;
            public static readonly int PlayerScoreOffsetY = 10;
            public static readonly string PlayerScore = "Game score: {0}";

        }

        public static class Config
        {
            public static readonly int EndMessageX = 45;
            public static readonly int EndMessageY = 15;
            public static readonly string EndMessage = "Would you like to continue?";
            public static readonly string EndMessageOption = "Y/N";
        }
    }
}
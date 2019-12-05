﻿namespace Chessboard
{
    static class TextMessages
    {
        public const string HEIGHT = "Height";
        public const string WIDTH = "Width";
        public const string HELP = "Exit - to complete the work.\nStart - to get started." +
            "\nSettings - to change cell design." +
            "\nAfter that you will need to enter the Height and Width values of the board.";
        public const string DESIGN_WHITE = "Set the design for white cells and press enter";
        public const string DESIGN_BLACK = "Set the design for black cells and press enter";
        public const string INCORRECT_INPUT = "Side is entered incorrectly" +
            "\nUse a numeric value from 1 to 2,147,483,647";
        public const string INCORRECT_INPUT_VALUE = "Use a positive value";
        public const string START_MODE = "start";
        public const string EXIT_MODE = "exit";
        public const string SETTINGS_MODE = "settings";
    }
}

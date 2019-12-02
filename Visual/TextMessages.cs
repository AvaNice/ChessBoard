using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    static class TextMessages
    {
        #region PublicMembers

        public const string HEIGHT = "Height";
        public const string WIDTH = "Width";
        public const string HELP = "Exit - to complete the work.\nStart - to get started.\nSettings - to change cell design." +
            "\nAfter that you will need to enter the Height and Width values of the board.";
        public const string DESIGN_WHITE = "Set the design for white cells and press enter";
        public const string DESIGN_BLACK = "Set the design for black cells and press enter";
        public const string INCORRECT_INPUT = "Use the numeric value to enter the Height and Width.";
        public const string START_MODE = "start";
        public const string EXIT_MODE = "exit";
        public const string SETTINGS_MODE = "settings";

        #endregion
    }
}

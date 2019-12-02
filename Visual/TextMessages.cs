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
        public const string Heigth = "Height";
        public const string Width = "Width";
        public const string Help = "Exit - to complete the work.\nStart - to get started.\nSettings - to change cell design." +
            "\nAfter that you will need to enter the Height and Width values of the board.";
        public const string DesignWhite = "Set the design for white cells and press enter";
        public const string DesignBlack = "Set the design for black cells and press enter";
        public const string IncorrectInput = "Use the numeric value to enter the Height and Width.";
        public const string StartMode = "start";
        public const string ExitMode = "exit";
        public const string SettingsMode = "settings";
        #endregion
    }
}

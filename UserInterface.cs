using NLog;
using System;

namespace Chessboard
{
    public class UserInterface : IUserInterface
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private readonly IBoardDrawer<string> _boardDrawer;

        private CellVisualization<string> _design = new CellVisualization<string>("*", " ");

        public UserInterface(IBoardDrawer<string> boardDrawer)
        {
            _boardDrawer = boardDrawer;
        }

        public void GetUserDesign()
        {
            _design = new CellVisualization<string>(GetCellDesign(TextMessages.DESIGN_WHITE)
                , GetCellDesign(TextMessages.DESIGN_BLACK));
        }

        private string GetCellDesign(string parameterName)
        {
            string design;

            Console.Write($"{parameterName} : ");
            design = Console.ReadLine();

            _logger.Info($"User set new design for ({parameterName}) - {design}");

            return design;
        }

        public int GetUserSide(string parameterName)
        {
            int parameterValue = 0;
            string input = string.Empty;

            Console.Write($"{parameterName} = ");

            input = Console.ReadLine();

            try
            {
                    parameterValue = Convert.ToInt32(input);

                    return parameterValue;
            }
            catch (OverflowException exception)
            {
                CaseIncorrectInput(parameterName, input, exception);
            }
            catch (FormatException exception)
            {
                CaseIncorrectInput(parameterName, input, exception);
            }

            return GetUserSide(parameterName);
        }

        public bool NeedRestart()
        {
            string input;
            bool result;

            Console.WriteLine(TextMessages.NEED_MORE);
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case TextMessages.YES:
                case TextMessages.YES_SECOND:
                    result = true;
                    break;

                case TextMessages.NO:
                case TextMessages.NO_SECOND:
                    result = false;
                    break;

                default:
                    _logger.Info($"UI default. User input {input}");
                    Console.WriteLine(TextMessages.CANT_READ_MODE);

                    return NeedRestart();
            }

            return result;
        }

        private void CaseIncorrectInput(string parameterName, string input, Exception exception = null)
        {
            Console.WriteLine(TextMessages.INCORRECT_INPUT);

            if (exception != null)
            {
                _logger.Error($"{exception.Message} input {parameterName} = {input}");
            }
            else
            {
                _logger.Error($"User input negative value {parameterName} = {input}");
            }
        }

        public bool NeedStart()
        {
            bool result;
            string userInput;

            userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case TextMessages.START_MODE:
                    result = true;
                    return result;
                    

                case TextMessages.SETTINGS_MODE:
                    GetUserDesign();
                    break;

                default:
                    Console.WriteLine(TextMessages.HELP);
                    _logger.Trace($"Default in UserMenu userMode input = ({userInput})");
                    break;

            }

            return NeedStart();
        }

        public void DrawBoard(IBoard board)
        {
            _boardDrawer.DrawChessBoard(board, _design);
        }
    }
}

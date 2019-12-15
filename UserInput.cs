using NLog;
using System;

namespace Chessboard
{
    public class UserInterface
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private Validator _valdator = new Validator();
        
        public CellVisualization<string> GetUserDesign()
        {
            return new CellVisualization<string>(GetCellDesign(TextMessages.DESIGN_WHITE)
                , GetCellDesign(TextMessages.DESIGN_BLACK));
        }

        private string GetCellDesign(string parameterName)
        {
            string design = string.Empty;

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
                if (_valdator.IsSide(input))
                {
                    parameterValue = Convert.ToInt32(input);

                    return parameterValue;
                }

                CaseIncorrectInput(parameterName, input);
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

        public bool IsOneMore()
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
                    Log.Logger.Information($"UI default. User input {input}");
                    Console.WriteLine(TextMessages.CANT_READ_MODE);

                    return IsOneMore();
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
    }
}

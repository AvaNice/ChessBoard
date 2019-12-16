using NLog;
using System;

namespace Chessboard
{
    public class Validator : IValidator
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public bool IsSide(string input)
        {
            double inputedSide;

            try
            {
                inputedSide = Convert.ToDouble(input);

                return IsMoreThanZero(inputedSide);
            }
            catch (FormatException ex)
            {
                _logger.Error($"{ex.Message} User input {input}");

                throw;
            }
            catch (OverflowException ex)
            {
                _logger.Error($"{ex.Message} User input {input}");

                throw;
            }
        }

        public bool IsMoreThanZero(double input)
        {
            if (input > 0)
            {
                return true;
            }

            return false;
        }
    }
}

using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class UserInput
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

        public int GetUserNumeric(string parameterName)
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
            }

            catch (Exception ex)
            {
                Console.WriteLine(TextMessages.INCORRECT_INPUT);

                _logger.Error($"UserInput {ex.Message}");
            }

            return GetUserNumeric(parameterName);
        }
    }
}

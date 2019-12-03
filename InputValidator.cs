using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class InputValidator
    {
        public int GetUserNumeric(string parameterName)
        {
            int parameterValue = 0;
            string input = string.Empty;

            Console.Write($"{parameterName} = ");

            input = Console.ReadLine();

            try
            {
                parameterValue = Convert.ToInt32(input);

                Program.Logger.Trace($"User enter {parameterName} = {parameterValue}");

                return parameterValue;
            }

            catch
            {
                Console.WriteLine(TextMessages.INCORRECT_INPUT);

                Program.Logger.Error($"Incorrect Input of {parameterName} - {input}");
            }

            return GetUserNumeric(parameterName);
        }
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

            Program.Logger.Info($"User set new design for ({parameterName}) - {design}");

            return design;
        }
    }
}

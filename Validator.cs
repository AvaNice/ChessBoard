using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class Validator
    {
        public bool IsSide(string input)
        {
            double inputedSide;

            try
            {
                inputedSide = Convert.ToDouble(input);

                if (inputedSide < 0)
                {
                    throw new FormatException($"Input {inputedSide} < 0");
                }
                
                return true;
            }

            catch
            {

                throw new InvalidCastException($"{input} is not numeric");
            }
        }
    }
}

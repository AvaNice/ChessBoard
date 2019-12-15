﻿using System;

namespace Chessboard
{
    public class Validator
    {
        public bool IsSide(string input)
        {
            double inputedSide;

            try
            {
                inputedSide = Convert.ToDouble(input);

                return IsMoreThanZero(inputedSide);
            }
            catch
            {
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

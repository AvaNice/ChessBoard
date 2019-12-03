using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public abstract class Cell : IDrawableCell
    {
        public CellType CellType { get; }

        protected Cell(CellType cellType)
        {
            CellType= cellType;
        }
    }
}

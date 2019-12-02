using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    abstract class Cell : IDrawableCell
    {
        #region PublicMembers

        public CellType CellType { get; }

        #endregion

        #region ProtectedMembers

        protected Cell(CellType cellType)
        {
            CellType= cellType;
        }

        #endregion
    }
}

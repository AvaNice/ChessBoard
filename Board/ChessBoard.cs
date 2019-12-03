using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class ChessBoard : Grid <Cell> , IBoard
    {
        #region PublicMembers

        public ChessBoard(int height, int width, Cell first, Cell second)
            :base(height,width)
        {
            BoardFiller.FillStaggered(this, first, second);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class CellVisualization<T> : ICellVisual<T>
    {
        #region PublicMembers
        public T White { get; }
        public T Black { get; }
        public CellVisualization(T white, T black)
        {
            White = white;
            Black = black;
        }
        #endregion
    }
}

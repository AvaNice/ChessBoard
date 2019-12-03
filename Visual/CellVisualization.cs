using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class CellVisualization<T> : ICellsVisual<T>
    {
        public T First { get; }

        public T Second { get; }

        public CellVisualization(T white, T black)
        {
            First = white;
            Second = black;
        }
    }
}

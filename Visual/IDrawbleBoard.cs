using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    interface IDrawbleBoard<T>
    {
        int Height { get; }

        int Width { get; }

        T this[int line, int column] { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public interface IBoard
    {
        int Height { get; }

        int Width { get; }

        Cell this[int line, int column] { get; set; }
    }
}

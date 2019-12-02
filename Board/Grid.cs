using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public class Grid : IBoard
    {
        #region PrivateMembers

        protected Cell[,] _grid;

        #endregion

        #region PublicMembers

        public int Height { get; }
        public int Width { get; }

        public Grid(int height, int width)
        {
            _grid = new Cell[height, width];
            Height = height;
            Width = width;
        }

        public Cell this[int line, int column]
        {
            get
            {
                return _grid[line, column];
            }
            set
            {
                _grid[line, column] = value;
            }
        }

        #endregion
    }
}

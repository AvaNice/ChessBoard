using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public class Grid <T> 
    {
        #region PrivateMembers

        protected T[,] _grid;

        #endregion

        #region PublicMembers

        public int Height { get; }
        public int Width { get; }

        public Grid(int height, int width)
        {
            _grid = new T[height, width];
            Height = height;
            Width = width;
        }

        public T this[int line, int column]
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

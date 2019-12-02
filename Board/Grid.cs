using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public class Grid<T>
    {
        #region PrivateMembers
        private readonly T[,] grid;
        #endregion

        #region PublicMembers
        public int Height { get; }
        public int Width { get; }

        public Grid(int height, int width)
        {
            grid = new T[height, width];
            Height = height;
            Width = width;
        }

        public T this[int line, int column]
        {
            get
            {
                return grid[line, column];
            }
            set
            {
                grid[line, column] = value;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class ChessBoard<T> : IDrawbleBoard<T> 
    {
        #region PublicMembers

        public int Height { get; }
        public int Width { get; }

        public ChessBoard(int height, int width, T first, T second)
        {
            Height = height;
            Width = width;
            _board = BuildBoadr(height, width);
            new BoardFiller<T>(_board, first, second);
        }

        public T this[int line, int column]
        {
            get
            {
                return _board[line, column];
            }
            set
            {
                _board[line, column] = value;
            }
        }

        #endregion

        #region PrivateMembers

        private Grid<T> _board;

        private static Grid<T> BuildBoadr(int height, int width)
        {
            return new BoardBuilder<T>().Build(height, width);
        }

        #endregion
    }
}

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
            board = BuildBoadr(height, width);
            new BoardFiller<T>(board, first, second);
        }
        public T this[int line, int column]
        {
            get
            {
                return board[line, column];
            }
            set
            {
                board[line, column] = value;
            }
        }
        #endregion

        #region PrivateMembers
        private Grid<T> board;

        private static Grid<T> BuildBoadr(int height, int width)
        {
            return new BoardBuilder<T>().Build(height, width);
        }
        #endregion
    }
}

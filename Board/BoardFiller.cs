using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public class BoardFiller<T>
    {
        #region PublicMembers
        public Grid<T> Board { get; }

        public BoardFiller(Grid<T> board, T first, T second)
        {
            Board = board;
            this.FillEveryFirst(first);
            this.FillEverySecond(second);
        }
        
        public static bool IsFirst(int line, int column)
        {
            if ((line % DividerForEven != 0) && (column % DividerForEven == 0))
            {
                return true;
            }
            else if ((line % DividerForEven == 0) && (column % DividerForEven != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region PrivateMembers
        private const int DividerForEven = 2;
        private void FillEveryFirst(T cell)
        {
            for (int i = 0; i < Board.Height; i++)
            {
                for (int y = 0; y < Board.Width; y++)
                {
                    if (IsFirst(i, y))
                    {
                        Board[i, y] = cell;
                    }
                }

            }
        }

        private void FillEverySecond(T cell)
        {
            for (int i = 0; i < Board.Height; i++)
            {
                for (int y = 0; y < Board.Width; y++)
                {
                    if (!IsFirst(i, y))
                    {
                        Board[i, y] = cell;
                    }
                }

            }
        }
        #endregion
    }
}

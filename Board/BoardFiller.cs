using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public static class BoardFiller
    {
        private const int DividerForEven = 2;

        public static void FillStaggered(IBoard board, Cell first, Cell second)
        {
            FillEveryFirst(board, first);
            FillEverySecond(board, second);
        }

        public static bool IsFirst(int line, int column)
        {
            if (((line % DividerForEven != 0) && (column % DividerForEven == 0))
                || ((line % DividerForEven == 0) && (column % DividerForEven != 0)))
            {
                return true;
            }

            return false;
        }

        private static void FillEveryFirst(IBoard board, Cell cell)
        {
            for (int i = 0; i < board.Height; i++)
            {
                for (int y = 0; y < board.Width; y++)
                {
                    if (IsFirst(i, y))
                    {
                        board[i, y] = cell;
                    }
                }

            }
        }

        private static void FillEverySecond(IBoard board, Cell cell)
        {
            for (int i = 0; i < board.Height; i++)
            {
                for (int y = 0; y < board.Width; y++)
                {
                    if (!IsFirst(i, y))
                    {
                        board[i, y] = cell;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    static class ChessBoardDrawer<T>
    {
        #region PublicMembers

        public static void DrawChessBoard(IDrawbleBoard<IDrawableCell> grid, ICellVisual<T> visual)
        {
            for (int i = 0; i < grid.Height; i++)
            {
                for (int y = 0; y < grid.Width; y++)
                {
                    DrawCell(grid[i, y], visual);
                }
                Console.Write("\n");
            }
        }

        #endregion

        #region PrivateMembers

        private static void DrawCell(IDrawableCell cell, ICellVisual<T> visual)
        {
            switch (cell.CellType)
            {
                case CellType.Black:
                    Console.Write(visual.Black);
                    break;
                case CellType.White:
                    Console.Write(visual.White);
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}

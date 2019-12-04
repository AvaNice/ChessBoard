using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class ChessBoardDrawer<T>
    {
        public void DrawChessBoard(IBoard grid, ICellsVisual<T> visual)
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

        private void DrawCell(IDrawableCell cell, ICellsVisual<T> visual)
        {
            switch (cell.CellType)
            {
                case CellType.Black:

                    Console.Write(visual.Second);

                    break;

                case CellType.White:

                    Console.Write(visual.First);

                    break;

                default:

                    break;
            }
        }
    }
}

namespace Chessboard
{
    public class ChessBoard : Grid <Cell> , IBoard
    {
        private const int DIVIDER_FOR_EVEN = 2;

        public ChessBoard(int height, int width)
            :base(height,width)
        {
        }

        public void FillStaggered(Cell first, Cell second)
        {
            FillEveryFirst(first);
            FillEverySecond(second);
        }

        public bool IsFirst(int line, int column)
        {
            if (((line % DIVIDER_FOR_EVEN != 0) && (column % DIVIDER_FOR_EVEN == 0))
                || ((line % DIVIDER_FOR_EVEN == 0) && (column % DIVIDER_FOR_EVEN != 0)))
            {
                return true;
            }

            return false;
        }

        private void FillEveryFirst(Cell cell)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int y = 0; y < Width; y++)
                {
                    if (IsFirst(i, y))
                    {
                        this[i, y] = cell;
                    }
                }

            }
        }

        private void FillEverySecond(Cell cell)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int y = 0; y < Width; y++)
                {
                    if (!IsFirst(i, y))
                    {
                        this[i, y] = cell;
                    }
                }
            }
        }
    }
}

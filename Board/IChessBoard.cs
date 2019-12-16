namespace Chessboard
{
    public interface IChessBoard : IBoard
    {
        void FillStaggered(Cell first, Cell second);

        bool IsFirst(int line, int column);
    }
}
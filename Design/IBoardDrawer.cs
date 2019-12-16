namespace Chessboard
{
    public interface IBoardDrawer<T>
    {
        void DrawChessBoard(IBoard grid, ICellsVisual<T> visual);
    }
}
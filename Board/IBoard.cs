namespace Chessboard
{
    public interface IBoard
    {
        int Height { get; }

        int Width { get; }

        Cell this[int line, int column] { get; set; }
    }
}

namespace Chessboard
{
    public interface ICellsVisual <T>
    {
        T First { get; }

        T Second { get; }
    }
}
namespace Chessboard
{
    interface ICellsVisual <T>
    {
        T First { get; }

        T Second { get; }
    }
}
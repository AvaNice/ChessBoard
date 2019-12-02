namespace Chessboard
{
    interface ICellVisual <T>
    {
        T White { get; }
        T Black { get; }
    }
}
namespace Chessboard
{
    class CellVisualization<T> : ICellsVisual<T>
    {
        public T First { get; }

        public T Second { get; }

        public CellVisualization(T white, T black)
        {
            First = white;
            Second = black;
        }
    }
}

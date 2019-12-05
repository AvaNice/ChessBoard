namespace Chessboard
{
    public abstract class Cell : IDrawableCell
    {
        public CellType CellType { get; }

        protected Cell(CellType cellType)
        {
            CellType= cellType;
        }
    }
}

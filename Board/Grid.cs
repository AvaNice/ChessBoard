namespace Chessboard
{
    public class Grid <T> 
    {
        protected T[,] _grid;

        public int Height { get; }

        public int Width { get; }

        public Grid(int height, int width)
        {
            _grid = new T[height, width];
            Height = height;
            Width = width;
        }

        public T this[int line, int column]
        {
            get
            {
                return _grid[line, column];
            }
            set
            {
                _grid[line, column] = value;
            }
        }
    }
}

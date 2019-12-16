namespace Chessboard
{
    public interface IValidator
    {
        bool IsMoreThanZero(double input);
        bool IsSide(string input);
    }
}